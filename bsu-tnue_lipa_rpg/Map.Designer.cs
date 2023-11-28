﻿namespace bsu_tnue_lipa_rpg
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.map_charac = new System.Windows.Forms.PictureBox();
            this.mapWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.cecscollision_pbox = new System.Windows.Forms.PictureBox();
            this.obcollision_pbox = new System.Windows.Forms.PictureBox();
            this.dg_pbox = new System.Windows.Forms.PictureBox();
            this.dg_map = new System.Windows.Forms.Label();
            this.next_pbox = new System.Windows.Forms.PictureBox();
            this.click_lbl = new System.Windows.Forms.Label();
            this.enter_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.map_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecscollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 50);
            this.panel1.TabIndex = 0;
            // 
            // map_charac
            // 
            this.map_charac.BackColor = System.Drawing.Color.Transparent;
            this.map_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.male_uni_front;
            this.map_charac.Location = new System.Drawing.Point(522, 378);
            this.map_charac.Name = "map_charac";
            this.map_charac.Size = new System.Drawing.Size(53, 86);
            this.map_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map_charac.TabIndex = 1;
            this.map_charac.TabStop = false;
            // 
            // mapWalkTimer
            // 
            this.mapWalkTimer.Interval = 90;
            this.mapWalkTimer.Tick += new System.EventHandler(this.mapWalkTimer_Tick);
            // 
            // cecscollision_pbox
            // 
            this.cecscollision_pbox.Location = new System.Drawing.Point(159, 370);
            this.cecscollision_pbox.Name = "cecscollision_pbox";
            this.cecscollision_pbox.Size = new System.Drawing.Size(48, 213);
            this.cecscollision_pbox.TabIndex = 2;
            this.cecscollision_pbox.TabStop = false;
            this.cecscollision_pbox.Tag = "cecs";
            // 
            // obcollision_pbox
            // 
            this.obcollision_pbox.Location = new System.Drawing.Point(977, 212);
            this.obcollision_pbox.Name = "obcollision_pbox";
            this.obcollision_pbox.Size = new System.Drawing.Size(48, 125);
            this.obcollision_pbox.TabIndex = 3;
            this.obcollision_pbox.TabStop = false;
            this.obcollision_pbox.Tag = "ob";
            // 
            // dg_pbox
            // 
            this.dg_pbox.BackColor = System.Drawing.Color.Transparent;
            this.dg_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.dialogue_base;
            this.dg_pbox.Location = new System.Drawing.Point(133, 470);
            this.dg_pbox.Name = "dg_pbox";
            this.dg_pbox.Size = new System.Drawing.Size(903, 194);
            this.dg_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dg_pbox.TabIndex = 4;
            this.dg_pbox.TabStop = false;
            // 
            // dg_map
            // 
            this.dg_map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dg_map.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_map.ForeColor = System.Drawing.Color.White;
            this.dg_map.Location = new System.Drawing.Point(171, 521);
            this.dg_map.Name = "dg_map";
            this.dg_map.Size = new System.Drawing.Size(827, 97);
            this.dg_map.TabIndex = 6;
            this.dg_map.Text = "Good morning, Red Spartan! \r\nYour first task today is to attend your Database cla" +
    "ss.  Your proctor will be Sir Tiquio for 7am - 10 am.  In your schedule, your ro" +
    "om is at CECS Building, Room 401.";
            // 
            // next_pbox
            // 
            this.next_pbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_pbox.Location = new System.Drawing.Point(971, 595);
            this.next_pbox.Name = "next_pbox";
            this.next_pbox.Size = new System.Drawing.Size(33, 32);
            this.next_pbox.TabIndex = 10;
            this.next_pbox.TabStop = false;
            this.next_pbox.Click += new System.EventHandler(this.next_pbox_Click);
            // 
            // click_lbl
            // 
            this.click_lbl.AutoSize = true;
            this.click_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.click_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_lbl.ForeColor = System.Drawing.Color.White;
            this.click_lbl.Location = new System.Drawing.Point(863, 603);
            this.click_lbl.Name = "click_lbl";
            this.click_lbl.Size = new System.Drawing.Size(124, 24);
            this.click_lbl.TabIndex = 11;
            this.click_lbl.Text = "Click to proceed..";
            // 
            // enter_lbl
            // 
            this.enter_lbl.AutoSize = true;
            this.enter_lbl.BackColor = System.Drawing.Color.Maroon;
            this.enter_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_lbl.ForeColor = System.Drawing.Color.White;
            this.enter_lbl.Location = new System.Drawing.Point(947, 599);
            this.enter_lbl.Name = "enter_lbl";
            this.enter_lbl.Size = new System.Drawing.Size(59, 28);
            this.enter_lbl.TabIndex = 14;
            this.enter_lbl.Text = "ENTER";
            this.enter_lbl.Visible = false;
            this.enter_lbl.Click += new System.EventHandler(this.enter_lbl_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.map_art;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.map_charac);
            this.Controls.Add(this.enter_lbl);
            this.Controls.Add(this.next_pbox);
            this.Controls.Add(this.click_lbl);
            this.Controls.Add(this.dg_map);
            this.Controls.Add(this.dg_pbox);
            this.Controls.Add(this.obcollision_pbox);
            this.Controls.Add(this.cecscollision_pbox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.map_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecscollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox map_charac;
        private System.Windows.Forms.Timer mapWalkTimer;
        private System.Windows.Forms.PictureBox cecscollision_pbox;
        private System.Windows.Forms.PictureBox obcollision_pbox;
        private System.Windows.Forms.PictureBox dg_pbox;
        private System.Windows.Forms.Label dg_map;
        private System.Windows.Forms.PictureBox next_pbox;
        private System.Windows.Forms.Label click_lbl;
        private System.Windows.Forms.Label enter_lbl;
    }
}