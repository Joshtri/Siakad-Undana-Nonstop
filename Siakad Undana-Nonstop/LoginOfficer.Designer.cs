namespace Siakad_Undana_Nonstop
{
    partial class LoginOfficer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOfficer));
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.Location = new System.Drawing.Point(166, 263);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Barlow Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(70, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Barlow Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(70, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextbox.Location = new System.Drawing.Point(166, 220);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 20);
            this.NameTextbox.TabIndex = 6;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.Font = new System.Drawing.Font("Barlow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(139, 334);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(71, 29);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pic
            // 
            this.Pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic.BackColor = System.Drawing.Color.Transparent;
            this.Pic.Image = ((System.Drawing.Image)(resources.GetObject("Pic.Image")));
            this.Pic.Location = new System.Drawing.Point(129, 102);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(92, 87);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Pic);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 449);
            this.panel1.TabIndex = 7;
            // 
            // LoginOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginOfficer";
            this.Text = "Siakad";
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.TextBox PasswordBox;
        public System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Panel panel1;
    }
}

