namespace Siakad_Undana_Nonstop.FormsMahasiswa
{
    partial class FormDaftarMahasiswa
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 383);
            this.panel1.Size = new System.Drawing.Size(797, 67);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(434, 16);
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Location = new System.Drawing.Point(181, 16);
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(57, 16);
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // labelJudul
            // 
            this.labelJudul.Location = new System.Drawing.Point(146, 0);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(309, 16);
            this.buttonHapus.Click += new System.EventHandler(this.ButtonHapus_Click);
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.Location = new System.Drawing.Point(664, 22);
            // 
            // FormDaftarMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormDaftarMahasiswa";
            this.Text = "FormDaftarMahasiswa";
            this.Activated += new System.EventHandler(this.FormDaftarMahasiswa_Activated);
            this.Load += new System.EventHandler(this.FormDaftarMahasiswa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}