namespace Siakad_Undana_Nonstop
{
    partial class Siakad_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siakad_Menu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitleBars = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GreetingUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.About = new Siakad_Undana_Nonstop.RJButton();
            this.Notes = new Siakad_Undana_Nonstop.RJButton();
            this.CalenderButton = new Siakad_Undana_Nonstop.RJButton();
            this.StatisticButton = new Siakad_Undana_Nonstop.RJButton();
            this.TitleBars.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TitleBars
            // 
            this.TitleBars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitleBars.Controls.Add(this.Clock);
            this.TitleBars.Controls.Add(this.pictureBox6);
            this.TitleBars.Controls.Add(this.BtnMin);
            this.TitleBars.Controls.Add(this.BtnMax);
            this.TitleBars.Controls.Add(this.label6);
            this.TitleBars.Controls.Add(this.BtnClose);
            this.TitleBars.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBars.Location = new System.Drawing.Point(0, 0);
            this.TitleBars.Name = "TitleBars";
            this.TitleBars.Size = new System.Drawing.Size(800, 30);
            this.TitleBars.TabIndex = 17;
            this.TitleBars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBars_MouseDown);
            // 
            // Clock
            // 
            this.Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clock.AutoSize = true;
            this.Clock.BackColor = System.Drawing.Color.Transparent;
            this.Clock.Font = new System.Drawing.Font("Copse", 9F);
            this.Clock.Location = new System.Drawing.Point(354, 7);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(61, 15);
            this.Clock.TabIndex = 18;
            this.Clock.Text = "xx:xx:xx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Siakad Undana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Menu : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.GreetingUser);
            this.panel1.Location = new System.Drawing.Point(-1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 93);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GreetingUser
            // 
            this.GreetingUser.AutoSize = true;
            this.GreetingUser.BackColor = System.Drawing.Color.Transparent;
            this.GreetingUser.Font = new System.Drawing.Font("Copse", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GreetingUser.Location = new System.Drawing.Point(117, 43);
            this.GreetingUser.Name = "GreetingUser";
            this.GreetingUser.Size = new System.Drawing.Size(267, 20);
            this.GreetingUser.TabIndex = 19;
            this.GreetingUser.Text = "Selamat Datang di Siakad UNDANA";
            this.GreetingUser.Click += new System.EventHandler(this.GreetingUser_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 101);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telp: 085xxx00 (Ani)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Biro Akademik dan Kemahasiswaan (BAK) - Kampus Baru Universitas Nusa Cendana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub Bagian Pendidikan dan Evaluasi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informasi lebih lanjut : ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.About);
            this.panel2.Controls.Add(this.Notes);
            this.panel2.Controls.Add(this.CalenderButton);
            this.panel2.Controls.Add(this.StatisticButton);
            this.panel2.Location = new System.Drawing.Point(-4, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 354);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMin.BackgroundImage")));
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Location = new System.Drawing.Point(701, 2);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(28, 26);
            this.BtnMin.TabIndex = 9;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMax.BackgroundImage")));
            this.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Location = new System.Drawing.Point(735, 2);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(28, 26);
            this.BtnMax.TabIndex = 7;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(769, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 26);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(646, 182);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Barlow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(627, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "Mata Kuliah";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Barlow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(497, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Semester";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(520, 192);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Barlow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nilai";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(390, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Barlow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(238, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Mahasiswa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.RosyBrown;
            this.About.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.About.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.About.BorderRadius = 6;
            this.About.BorderSize = 0;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Location = new System.Drawing.Point(26, 230);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(112, 38);
            this.About.TabIndex = 3;
            this.About.Text = "About";
            this.About.TextColor = System.Drawing.Color.White;
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.RosyBrown;
            this.Notes.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.Notes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Notes.BorderRadius = 6;
            this.Notes.BorderSize = 0;
            this.Notes.FlatAppearance.BorderSize = 0;
            this.Notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notes.ForeColor = System.Drawing.Color.White;
            this.Notes.Location = new System.Drawing.Point(26, 173);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(112, 38);
            this.Notes.TabIndex = 2;
            this.Notes.Text = "Notes";
            this.Notes.TextColor = System.Drawing.Color.White;
            this.Notes.UseVisualStyleBackColor = false;
            // 
            // CalenderButton
            // 
            this.CalenderButton.BackColor = System.Drawing.Color.RosyBrown;
            this.CalenderButton.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.CalenderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CalenderButton.BorderRadius = 6;
            this.CalenderButton.BorderSize = 0;
            this.CalenderButton.FlatAppearance.BorderSize = 0;
            this.CalenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalenderButton.ForeColor = System.Drawing.Color.White;
            this.CalenderButton.Location = new System.Drawing.Point(26, 119);
            this.CalenderButton.Name = "CalenderButton";
            this.CalenderButton.Size = new System.Drawing.Size(112, 38);
            this.CalenderButton.TabIndex = 1;
            this.CalenderButton.Text = "Calender";
            this.CalenderButton.TextColor = System.Drawing.Color.White;
            this.CalenderButton.UseVisualStyleBackColor = false;
            // 
            // StatisticButton
            // 
            this.StatisticButton.BackColor = System.Drawing.Color.RosyBrown;
            this.StatisticButton.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.StatisticButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.StatisticButton.BorderRadius = 6;
            this.StatisticButton.BorderSize = 0;
            this.StatisticButton.FlatAppearance.BorderSize = 0;
            this.StatisticButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticButton.ForeColor = System.Drawing.Color.White;
            this.StatisticButton.Location = new System.Drawing.Point(26, 70);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(112, 38);
            this.StatisticButton.TabIndex = 0;
            this.StatisticButton.Text = "Statistic";
            this.StatisticButton.TextColor = System.Drawing.Color.White;
            this.StatisticButton.UseVisualStyleBackColor = false;
            // 
            // Siakad_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitleBars);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Siakad_Menu";
            this.Text = "Siakad_Menu";
            this.Load += new System.EventHandler(this.Siakad_Menu_Load);
            this.TitleBars.ResumeLayout(false);
            this.TitleBars.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel TitleBars;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnClose;
        //private RJButton rjButton3;
        //private RJButton rjButton2;
        //private RJButton rjButton1;
        private System.Windows.Forms.Label label5;
        //private RJButton rjButton4;
        private RJButton About;
        private RJButton Notes;
        private RJButton CalenderButton;
        private RJButton StatisticButton;
        public System.Windows.Forms.Label GreetingUser;
    }
}