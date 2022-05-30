namespace Siakad_Undana_Nonstop.FormsMahasiswa
{
    partial class FormUbahMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahMahasiswa));
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAngkatan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTanggalLahir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxJK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.dataGridMhs = new System.Windows.Forms.DataGridView();
            this.ShowDataButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowDataButton);
            this.panel1.Controls.SetChildIndex(this.buttonSimpan, 0);
            this.panel1.Controls.SetChildIndex(this.buttonClose, 0);
            this.panel1.Controls.SetChildIndex(this.ShowDataButton, 0);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.FlatAppearance.BorderSize = 0;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxNIM);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxAngkatan);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxTanggalLahir);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxJK);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxNama);
            this.panel2.Location = new System.Drawing.Point(185, 80);
            this.panel2.Size = new System.Drawing.Size(420, 202);
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(194, 50);
            this.textBoxNIM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(146, 20);
            this.textBoxNIM.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Copse", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 14);
            this.label9.TabIndex = 45;
            this.label9.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copse", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "NIM";
            // 
            // textBoxAngkatan
            // 
            this.textBoxAngkatan.Location = new System.Drawing.Point(194, 170);
            this.textBoxAngkatan.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAngkatan.Name = "textBoxAngkatan";
            this.textBoxAngkatan.Size = new System.Drawing.Size(146, 20);
            this.textBoxAngkatan.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copse", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nama";
            // 
            // textBoxTanggalLahir
            // 
            this.textBoxTanggalLahir.Location = new System.Drawing.Point(194, 126);
            this.textBoxTanggalLahir.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTanggalLahir.Name = "textBoxTanggalLahir";
            this.textBoxTanggalLahir.Size = new System.Drawing.Size(146, 20);
            this.textBoxTanggalLahir.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copse", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "Jenis kelamin";
            // 
            // textBoxJK
            // 
            this.textBoxJK.Location = new System.Drawing.Point(194, 86);
            this.textBoxJK.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJK.Name = "textBoxJK";
            this.textBoxJK.Size = new System.Drawing.Size(146, 20);
            this.textBoxJK.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Copse", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tanggal lahir";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(194, 16);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(146, 20);
            this.textBoxNama.TabIndex = 41;
            // 
            // dataGridMhs
            // 
            this.dataGridMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMhs.Location = new System.Drawing.Point(200, 288);
            this.dataGridMhs.Name = "dataGridMhs";
            this.dataGridMhs.Size = new System.Drawing.Size(405, 90);
            this.dataGridMhs.TabIndex = 22;
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowDataButton.Image")));
            this.ShowDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowDataButton.Location = new System.Drawing.Point(3, 19);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(93, 30);
            this.ShowDataButton.TabIndex = 23;
            this.ShowDataButton.Text = "Show Data";
            this.ShowDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowDataButton.UseVisualStyleBackColor = true;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // FormUbahMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridMhs);
            this.Name = "FormUbahMahasiswa";
            this.Text = "FormUbahMahasiswa";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridMhs, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMhs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox textBoxNIM;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox textBoxAngkatan;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox textBoxTanggalLahir;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox textBoxJK;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.DataGridView dataGridMhs;
        protected System.Windows.Forms.Button ShowDataButton;
    }
}