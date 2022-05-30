namespace Siakad_Undana_Nonstop.FormsNilai
{
    partial class FormTambahUbahNilai
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
            this.textBoxNilaiHuruf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNilaiAngka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKodeMk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdSemester = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Controls.Add(this.textBoxNilaiHuruf);
            this.panel2.Controls.Add(this.textBoxIdSemester);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxNilaiAngka);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxKodeMk);
            this.panel2.Controls.Add(this.textBoxNim);
            this.panel2.Controls.Add(this.label1);
            // 
            // textBoxNilaiHuruf
            // 
            this.textBoxNilaiHuruf.Location = new System.Drawing.Point(154, 187);
            this.textBoxNilaiHuruf.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNilaiHuruf.Name = "textBoxNilaiHuruf";
            this.textBoxNilaiHuruf.Size = new System.Drawing.Size(249, 20);
            this.textBoxNilaiHuruf.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nilai Huruf";
            // 
            // textBoxNilaiAngka
            // 
            this.textBoxNilaiAngka.Location = new System.Drawing.Point(154, 153);
            this.textBoxNilaiAngka.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNilaiAngka.Name = "textBoxNilaiAngka";
            this.textBoxNilaiAngka.Size = new System.Drawing.Size(249, 20);
            this.textBoxNilaiAngka.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nilai Angka";
            // 
            // textBoxNim
            // 
            this.textBoxNim.Location = new System.Drawing.Point(154, 121);
            this.textBoxNim.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNim.Name = "textBoxNim";
            this.textBoxNim.Size = new System.Drawing.Size(249, 20);
            this.textBoxNim.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "NIM";
            // 
            // textBoxKodeMk
            // 
            this.textBoxKodeMk.Location = new System.Drawing.Point(154, 88);
            this.textBoxKodeMk.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodeMk.Name = "textBoxKodeMk";
            this.textBoxKodeMk.Size = new System.Drawing.Size(249, 20);
            this.textBoxKodeMk.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kode MK";
            // 
            // textBoxIdSemester
            // 
            this.textBoxIdSemester.Location = new System.Drawing.Point(154, 53);
            this.textBoxIdSemester.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdSemester.Name = "textBoxIdSemester";
            this.textBoxIdSemester.Size = new System.Drawing.Size(249, 20);
            this.textBoxIdSemester.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Id Semester";
            // 
            // FormTambahUbahNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormTambahUbahNilai";
            this.Text = "FormTambahUbahNilai";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNilaiHuruf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNilaiAngka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKodeMk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdSemester;
        private System.Windows.Forms.Label label6;
    }
}