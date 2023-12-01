﻿using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.CECS_floors_uc
{
    partial class CECS_fourthflr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sirtiquio_pbox = new System.Windows.Forms.PictureBox();
            this.cecsfourthflr_charac = new System.Windows.Forms.PictureBox();
            this.cecsfourthWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.elevcollision_pbox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sir_dg = new System.Windows.Forms.Label();
            this.door1_panel = new System.Windows.Forms.Panel();
            this.door2_panel = new System.Windows.Forms.Panel();
            this.door3_panel = new System.Windows.Forms.Panel();
            this.success_door = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sirtiquio_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecsfourthflr_charac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sirtiquio_pbox
            // 
            this.sirtiquio_pbox.BackColor = System.Drawing.Color.Transparent;
            this.sirtiquio_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.Sir_Daryl;
            this.sirtiquio_pbox.Location = new System.Drawing.Point(1058, 184);
            this.sirtiquio_pbox.Name = "sirtiquio_pbox";
            this.sirtiquio_pbox.Size = new System.Drawing.Size(101, 119);
            this.sirtiquio_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirtiquio_pbox.TabIndex = 0;
            this.sirtiquio_pbox.TabStop = false;
            // 
            // cecsfourthflr_charac
            // 
            this.cecsfourthflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.cecsfourthflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.cecsfourthflr_charac.Location = new System.Drawing.Point(54, 262);
            this.cecsfourthflr_charac.Name = "cecsfourthflr_charac";
            this.cecsfourthflr_charac.Size = new System.Drawing.Size(101, 119);
            this.cecsfourthflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cecsfourthflr_charac.TabIndex = 3;
            this.cecsfourthflr_charac.TabStop = false;
            // 
            // cecsfourthWalkTimer
            // 
            this.cecsfourthWalkTimer.Enabled = true;
            this.cecsfourthWalkTimer.Interval = 50;
            this.cecsfourthWalkTimer.Tick += new System.EventHandler(this.cecsfourthWalkTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1296, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "To elevator ->";
            // 
            // elevcollision_pbox
            // 
            this.elevcollision_pbox.Location = new System.Drawing.Point(1404, 206);
            this.elevcollision_pbox.Name = "elevcollision_pbox";
            this.elevcollision_pbox.Size = new System.Drawing.Size(29, 185);
            this.elevcollision_pbox.TabIndex = 5;
            this.elevcollision_pbox.TabStop = false;
            this.elevcollision_pbox.Tag = "go_to_elev";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.sir_dialogue;
            this.pictureBox1.Location = new System.Drawing.Point(154, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1189, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // sir_dg
            // 
            this.sir_dg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.sir_dg.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sir_dg.ForeColor = System.Drawing.Color.White;
            this.sir_dg.Location = new System.Drawing.Point(413, 439);
            this.sir_dg.Name = "sir_dg";
            this.sir_dg.Size = new System.Drawing.Size(808, 112);
            this.sir_dg.TabIndex = 7;
            this.sir_dg.Text = "Congratulations Red Spartan! Let\'s now proceed\r\nto our class here in Room 401,  s" +
    "hall we?";
            this.sir_dg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // door1_panel
            // 
            this.door1_panel.BackColor = System.Drawing.Color.Transparent;
            this.door1_panel.Location = new System.Drawing.Point(968, 162);
            this.door1_panel.Name = "door1_panel";
            this.door1_panel.Size = new System.Drawing.Size(11, 87);
            this.door1_panel.TabIndex = 8;
            this.door1_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.door_panel_Paint);
            // 
            // door2_panel
            // 
            this.door2_panel.BackColor = System.Drawing.Color.Transparent;
            this.door2_panel.Location = new System.Drawing.Point(969, 162);
            this.door2_panel.Name = "door2_panel";
            this.door2_panel.Size = new System.Drawing.Size(70, 10);
            this.door2_panel.TabIndex = 0;
            // 
            // door3_panel
            // 
            this.door3_panel.BackColor = System.Drawing.Color.Transparent;
            this.door3_panel.Location = new System.Drawing.Point(1029, 167);
            this.door3_panel.Name = "door3_panel";
            this.door3_panel.Size = new System.Drawing.Size(10, 82);
            this.door3_panel.TabIndex = 1;
            // 
            // success_door
            // 
            this.success_door.Location = new System.Drawing.Point(979, 174);
            this.success_door.Name = "success_door";
            this.success_door.Size = new System.Drawing.Size(50, 74);
            this.success_door.TabIndex = 9;
            // 
            // CECS_fourthflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.cecs_hallway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.success_door);
            this.Controls.Add(this.door3_panel);
            this.Controls.Add(this.door2_panel);
            this.Controls.Add(this.door1_panel);
            this.Controls.Add(this.sir_dg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elevcollision_pbox);
            this.Controls.Add(this.cecsfourthflr_charac);
            this.Controls.Add(this.sirtiquio_pbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CECS_fourthflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.sirtiquio_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecsfourthflr_charac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sirtiquio_pbox;
        private System.Windows.Forms.PictureBox cecsfourthflr_charac;
        public System.Windows.Forms.Timer cecsfourthWalkTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox elevcollision_pbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sir_dg;
        private System.Windows.Forms.Panel door1_panel;
        private Panel door2_panel;
        private Panel door3_panel;
        private Panel success_door;
    }
}
