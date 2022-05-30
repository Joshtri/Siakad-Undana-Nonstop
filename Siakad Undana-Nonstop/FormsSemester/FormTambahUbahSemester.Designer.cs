namespace Siakad_Undana_Nonstop.FormsSemester
{
    partial class FormTambahUbahSemester
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
            this.textBoxNamaSemester = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdSemester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.textBoxNamaSemester);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxIdSemester);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(208, 79);
            this.panel2.Size = new System.Drawing.Size(419, 172);
            // 
            // textBoxNamaSemester
            // 
            this.textBoxNamaSemester.Location = new System.Drawing.Point(185, 94);
            this.textBoxNamaSemester.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamaSemester.Name = "textBoxNamaSemester";
            this.textBoxNamaSemester.Size = new System.Drawing.Size(141, 20);
            this.textBoxNamaSemester.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nama Semester";
            // 
            // textBoxIdSemester
            // 
            this.textBoxIdSemester.Location = new System.Drawing.Point(185, 59);
            this.textBoxIdSemester.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdSemester.Name = "textBoxIdSemester";
            this.textBoxIdSemester.Size = new System.Drawing.Size(141, 20);
            this.textBoxIdSemester.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id Semester";
            // 
            // FormTambahUbahSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormTambahUbahSemester";
            this.Text = "FormTambahUbahSemester";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNamaSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdSemester;
        private System.Windows.Forms.Label label1;
    }
}