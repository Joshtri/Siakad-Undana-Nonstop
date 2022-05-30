namespace Siakad_Undana_Nonstop.FormsSemester
{
    partial class FormUbahSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahSemester));
            this.textBoxNamaSemester = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdSemester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowDataButton = new System.Windows.Forms.Button();
            this.DataGridSemester = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSemester)).BeginInit();
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
            this.panel2.Controls.Add(this.textBoxNamaSemester);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxIdSemester);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(202, 70);
            this.panel2.Size = new System.Drawing.Size(398, 187);
            // 
            // textBoxNamaSemester
            // 
            this.textBoxNamaSemester.Location = new System.Drawing.Point(170, 101);
            this.textBoxNamaSemester.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamaSemester.Name = "textBoxNamaSemester";
            this.textBoxNamaSemester.Size = new System.Drawing.Size(141, 20);
            this.textBoxNamaSemester.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nama Semester";
            // 
            // textBoxIdSemester
            // 
            this.textBoxIdSemester.Location = new System.Drawing.Point(170, 66);
            this.textBoxIdSemester.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdSemester.Name = "textBoxIdSemester";
            this.textBoxIdSemester.Size = new System.Drawing.Size(141, 20);
            this.textBoxIdSemester.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id Semester";
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowDataButton.Image")));
            this.ShowDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowDataButton.Location = new System.Drawing.Point(20, 19);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(93, 30);
            this.ShowDataButton.TabIndex = 24;
            this.ShowDataButton.Text = "Show Data";
            this.ShowDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowDataButton.UseVisualStyleBackColor = true;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // DataGridSemester
            // 
            this.DataGridSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSemester.Location = new System.Drawing.Point(214, 257);
            this.DataGridSemester.Name = "DataGridSemester";
            this.DataGridSemester.Size = new System.Drawing.Size(373, 121);
            this.DataGridSemester.TabIndex = 23;
            // 
            // FormUbahSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridSemester);
            this.Name = "FormUbahSemester";
            this.Text = "FormUbahSemester";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.DataGridSemester, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSemester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNamaSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdSemester;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button ShowDataButton;
        private System.Windows.Forms.DataGridView DataGridSemester;
    }
}