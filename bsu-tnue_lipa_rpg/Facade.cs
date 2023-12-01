﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg
{
    public partial class Facade : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        bool go_up, go_down, go_left, go_right;
        int walk = 20;
        public Facade()
        {
            InitializeComponent();
            Bedroom.instance.characBack(facade_charac);

        }
        bool openMenu = false;
        bool openHint = false;


        #region menu & hint events
        private void menu_pbox_Click(object sender, EventArgs e)
        {
            if (openMenu == false)
            {
                openMenu = true;
                viewmenu_panel.Visible = true;
                viewmenu_panel.BringToFront();
                facadeWalkTimer.Stop();
            }
            else
            {
                openMenu = false;
                viewmenu_panel.Visible = false;
                facadeWalkTimer.Start();
            }
        }

        private void hint_pbox_Click(object sender, EventArgs e)
        {
            if (openHint == false)
            {
                openHint = true;
                hint_panel.Visible = true;
                hint_panel.BringToFront();
            }
            else
            {
                openHint = false;
                hint_panel.Visible = false;
            }
        }
        #endregion

        #region hover menu events
        private void tasks_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(tasks_panel, tasks_lbl);
        }

        private void tasks_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(tasks_panel, tasks_lbl);
        }

        private void achievs_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(achievs_panel, achievs_lbl);
        }

        private void achievs_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(achievs_panel, achievs_lbl);
        }

        private void return_hoverin(object sender, EventArgs e)
        {
            Bedroom.instance.hoverChange(return_panel, return_label);
        }

        private void return_hoverout(object sender, EventArgs e)
        {
            Bedroom.instance.hoverReset(return_panel, return_label);
        }
        #endregion

        private void facadeWalkTimer_Tick(object sender, EventArgs e)
        {
            if (go_left == true && facade_charac.Left > 0)
            {
                facade_charac.Left -= walk;
            }
            if (go_right == true && facade_charac.Left + facade_charac.Width < this.ClientSize.Width)
            {
                facade_charac.Left += walk;
            }
            if (go_up == true && facade_charac.Top > 46)
            {
                facade_charac.Top -= walk;
            }
            if (go_down == true && facade_charac.Top + facade_charac.Height < this.ClientSize.Height)
            {
                facade_charac.Top += walk;
            }

            //to interact with guard
            foreach (Control interact in this.Controls)
            {
                if (interact is PictureBox && (string)interact.Tag == "interact_w_guard")
                {
                    if (facade_charac.Bounds.IntersectsWith(interact.Bounds))
                    {
                        //stop character movement
                        //facadeWalkTimer.Stop();

                        //move character away from collision box
                        facade_charac.Location = new Point(277, 322);

                        //reset boolean directions
                        go_left = false;
                        go_right = false;
                        go_up = false;
                        go_down = false;

                        //code here to initiate dialogue:
                        //
                        //

                        //temporary code to go to map
                        //if makapasok
                        Map gotomap = new Map();
                        this.Hide();
                        gotomap.ShowDialog();
                        this.Close();
                        //else balik sa bedroom
                        
                        
                    }
                }
            }

            //to return home
            foreach (Control gohome in this.Controls)
            {
                if (gohome is PictureBox && (string)gohome.Tag == "return_home")
                {
                    if (facade_charac.Bounds.IntersectsWith(gohome.Bounds))
                    {
                        //stop character movement
                        facadeWalkTimer.Stop();
                        DialogResult sure = MessageBox.Show("Are you sure you want to go to bed? Ur garments will revert..", "Warning", MessageBoxButtons.YesNo);
                        if (sure == DialogResult.Yes) { 


                            //switch to closet form
                            this.Hide();
                            
                            Bedroom returned = new Bedroom();
                            returned.CHARAC_CLOTHES = "BED";
                            Closet.Garments_Worn[0, 0] = "";
                            Closet.Garments_Worn[0, 1] = "";
                            Closet.Garments_Worn[0, 2] = "";
                            Closet.Garments_Worn[0, 3] = "";
                            returned.ShowDialog();
                            this.Close();
                        }
                        else {

                            //reset boolean directions
                            go_left = false;
                            go_right = false;
                            go_up = false;
                            go_down = false;


                            //move character away from collision boxdd
                            facadeWalkTimer.Start();
                            facade_charac.Location = new Point(58, 398);
                            MessageBox.Show("Lakad matatag..");
                            
                        }
                    }
                }
            }
        }

        private void key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = true;
                Bedroom.instance.characLeft(facade_charac);
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = true;
                Bedroom.instance.characRight(facade_charac);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = true;
                Bedroom.instance.characBack(facade_charac);
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = true;
                Bedroom.instance.characFront(facade_charac);
            }
        }

        private void key_is_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                go_left = false;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                go_right = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                go_up = false;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                go_down = false;
            }
        }

        

    }
}
