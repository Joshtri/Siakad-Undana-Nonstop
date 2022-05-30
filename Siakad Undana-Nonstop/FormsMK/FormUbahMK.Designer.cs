namespace Siakad_Undana_Nonstop.FormsMK
{
    partial class FormUbahMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahMK));
            this.textBoxJumlahSks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDesripsiMk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNamaMk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKodeMk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridMK = new System.Windows.Forms.DataGridView();
            this.ShowDataButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMK)).BeginInit();
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
            this.panel2.Controls.Add(this.textBoxJumlahSks);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxDesripsiMk);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxNamaMk);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxKodeMk);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(191, 70);
            this.panel2.Size = new System.Drawing.Size(413, 178);
            // 
            // textBoxJumlahSks
            // 
            this.textBoxJumlahSks.Location = new System.Drawing.Point(120, 131);
            this.textBoxJumlahSks.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJumlahSks.Name = "textBoxJumlahSks";
            this.textBoxJumlahSks.Size = new System.Drawing.Size(249, 20);
            this.textBoxJumlahSks.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Jumlah SKS";
            // 
            // textBoxDesripsiMk
            // 
            this.textBoxDesripsiMk.Location = new System.Drawing.Point(120, 99);
            this.textBoxDesripsiMk.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDesripsiMk.Name = "textBoxDesripsiMk";
            this.textBoxDesripsiMk.Size = new System.Drawing.Size(249, 20);
            this.textBoxDesripsiMk.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Deskripsi";
            // 
            // textBoxNamaMk
            // 
            this.textBoxNamaMk.Location = new System.Drawing.Point(120, 67);
            this.textBoxNamaMk.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamaMk.Name = "textBoxNamaMk";
            this.textBoxNamaMk.Size = new System.Drawing.Size(249, 20);
            this.textBoxNamaMk.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nama MK";
            // 
            // textBoxKodeMk
            // 
            this.textBoxKodeMk.Location = new System.Drawing.Point(120, 32);
            this.textBoxKodeMk.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodeMk.Name = "textBoxKodeMk";
            this.textBoxKodeMk.Size = new System.Drawing.Size(249, 20);
            this.textBoxKodeMk.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Kode MK";
            // 
            // DataGridMK
            // 
            this.DataGridMK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMK.Location = new System.Drawing.Point(191, 254);
            this.DataGridMK.Name = "DataGridMK";
            this.DataGridMK.Size = new System.Drawing.Size(413, 124);
            this.DataGridMK.TabIndex = 22;
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowDataButton.Image")));
            this.ShowDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowDataButton.Location = new System.Drawing.Point(20, 19);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(93, 30);
            this.ShowDataButton.TabIndex = 25;
            this.ShowDataButton.Text = "Show Data";
            this.ShowDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowDataButton.UseVisualStyleBackColor = true;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // FormUbahMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridMK);
            this.Name = "FormUbahMK";
            this.Text = "FormUbahMK";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.DataGridMK, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJumlahSks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDesripsiMk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNamaMk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKodeMk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridMK;
        protected System.Windows.Forms.Button ShowDataButton;
    }
}