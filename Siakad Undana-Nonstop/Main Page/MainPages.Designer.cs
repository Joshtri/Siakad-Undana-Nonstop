﻿namespace Siakad_Undana_Nonstop.MainPage
{
    partial class MainPages
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButton1 = new Siakad_Undana_Nonstop.RJButton();
            this.OfficerButtonLogin = new Siakad_Undana_Nonstop.RJButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Siakad_Undana_Nonstop.Properties.Resources.BG_UNDANA;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.OfficerButtonLogin);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-27, -36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 396);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(159, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 57);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat datang di Siakad UNDANA berbasis Desktop Application";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "silahkan melakukan akses login agar dapat mengakses  Siakad UNDANA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Siakad_Undana_Nonstop.Properties.Resources.Logo_Undana_copy3;
            this.pictureBox1.Location = new System.Drawing.Point(291, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Peru;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Peru;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(381, 298);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 8;
            this.rjButton1.Text = "Student";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // OfficerButtonLogin
            // 
            this.OfficerButtonLogin.BackColor = System.Drawing.Color.Peru;
            this.OfficerButtonLogin.BackgroundColor = System.Drawing.Color.Peru;
            this.OfficerButtonLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.OfficerButtonLogin.BorderRadius = 10;
            this.OfficerButtonLogin.BorderSize = 0;
            this.OfficerButtonLogin.FlatAppearance.BorderSize = 0;
            this.OfficerButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OfficerButtonLogin.ForeColor = System.Drawing.Color.White;
            this.OfficerButtonLogin.Location = new System.Drawing.Point(193, 298);
            this.OfficerButtonLogin.Name = "OfficerButtonLogin";
            this.OfficerButtonLogin.Size = new System.Drawing.Size(150, 40);
            this.OfficerButtonLogin.TabIndex = 7;
            this.OfficerButtonLogin.Text = "Officer";
            this.OfficerButtonLogin.TextColor = System.Drawing.Color.White;
            this.OfficerButtonLogin.UseVisualStyleBackColor = false;
            this.OfficerButtonLogin.Click += new System.EventHandler(this.OfficerButtonLogin_Click);
            // 
            // MainPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(671, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainPages";
            this.Text = "MainPages";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJButton rjButton1;
        private RJButton OfficerButtonLogin;
    }
}