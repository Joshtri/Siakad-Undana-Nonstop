namespace Siakad_Undana_Nonstop.FormsNilai
{
    partial class FormUbahNilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahNilai));
            this.textBoxNilaiHuruf = new System.Windows.Forms.TextBox();
            this.textBoxIdSemester = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNilaiAngka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKodeMk = new System.Windows.Forms.TextBox();
            this.textBoxNim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridNilai = new System.Windows.Forms.DataGridView();
            this.ShowDataButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNilai)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(199, 69);
            this.panel2.Size = new System.Drawing.Size(414, 192);
            // 
            // textBoxNilaiHuruf
            // 
            this.textBoxNilaiHuruf.Location = new System.Drawing.Point(107, 147);
            this.textBoxNilaiHuruf.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNilaiHuruf.Name = "textBoxNilaiHuruf";
            this.textBoxNilaiHuruf.Size = new System.Drawing.Size(249, 20);
            this.textBoxNilaiHuruf.TabIndex = 49;
            // 
            // textBoxIdSemester
            // 
            this.textBoxIdSemester.Location = new System.Drawing.Point(107, 13);
            this.textBoxIdSemester.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdSemester.Name = "textBoxIdSemester";
            this.textBoxIdSemester.Size = new System.Drawing.Size(249, 20);
            this.textBoxIdSemester.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nilai Huruf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Id Semester";
            // 
            // textBoxNilaiAngka
            // 
            this.textBoxNilaiAngka.Location = new System.Drawing.Point(107, 113);
            this.textBoxNilaiAngka.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNilaiAngka.Name = "textBoxNilaiAngka";
            this.textBoxNilaiAngka.Size = new System.Drawing.Size(249, 20);
            this.textBoxNilaiAngka.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Kode MK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nilai Angka";
            // 
            // textBoxKodeMk
            // 
            this.textBoxKodeMk.Location = new System.Drawing.Point(107, 48);
            this.textBoxKodeMk.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodeMk.Name = "textBoxKodeMk";
            this.textBoxKodeMk.Size = new System.Drawing.Size(249, 20);
            this.textBoxKodeMk.TabIndex = 43;
            // 
            // textBoxNim
            // 
            this.textBoxNim.Location = new System.Drawing.Point(107, 81);
            this.textBoxNim.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNim.Name = "textBoxNim";
            this.textBoxNim.Size = new System.Drawing.Size(249, 20);
            this.textBoxNim.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "NIM";
            // 
            // DataGridNilai
            // 
            this.DataGridNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNilai.Location = new System.Drawing.Point(169, 267);
            this.DataGridNilai.Name = "DataGridNilai";
            this.DataGridNilai.Size = new System.Drawing.Size(444, 111);
            this.DataGridNilai.TabIndex = 22;
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowDataButton.Image")));
            this.ShowDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowDataButton.Location = new System.Drawing.Point(20, 19);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(93, 30);
            this.ShowDataButton.TabIndex = 23;
            this.ShowDataButton.Text = "Show Data";
            this.ShowDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowDataButton.UseVisualStyleBackColor = true;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // FormUbahNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 448);
            this.Controls.Add(this.DataGridNilai);
            this.Name = "FormUbahNilai";
            this.Text = "FormUbahNilai";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.DataGridNilai, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNilai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNilaiHuruf;
        private System.Windows.Forms.TextBox textBoxIdSemester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNilaiAngka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKodeMk;
        private System.Windows.Forms.TextBox textBoxNim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridNilai;
        protected System.Windows.Forms.Button ShowDataButton;
    }
}