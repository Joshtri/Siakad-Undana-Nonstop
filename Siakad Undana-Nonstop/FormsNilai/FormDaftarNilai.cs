using Siakad_Undana_Nonstop.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siakad_Undana_Nonstop.Entity;

namespace Siakad_Undana_Nonstop.FormsNilai
{
    public partial class FormDaftarNilai : BaseForm
    {
        FormTambahUbahNilai FormchangeGrades;
        FormHapusNilai DeleteFormGrades;
       
        public FormDaftarNilai()
        {
            InitializeComponent();

            labelJudul.Text = "Daftar Nilai";
           
           // BaseFormdataGridViewData.DataSource = Listgrades;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (FormchangeGrades == null || FormchangeGrades.IsDisposed)
            {
                FormchangeGrades = new FormTambahUbahNilai();
            }

            FormchangeGrades.LabelJudulUbahtambah.Text = "Tambah Nilai";
            FormchangeGrades.Adding_Operation = true;
            FormchangeGrades.Show();
            FormchangeGrades.BringToFront();
            Hide();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (FormchangeGrades == null || FormchangeGrades.IsDisposed)
            {
                FormchangeGrades = new FormTambahUbahNilai();
            }

            FormchangeGrades.LabelJudulUbahtambah.Text = "Ubah Nilai";
            FormchangeGrades.Adding_Operation = false;
            FormchangeGrades.Show();
            FormchangeGrades.BringToFront();
            Hide();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (DeleteFormGrades == null || DeleteFormGrades.IsDisposed)
            {
                DeleteFormGrades = new FormHapusNilai();
            }

            DeleteFormGrades.LabelJudulUbahtambah.Text = "Hapus Data Nilai";
            DeleteFormGrades.Adding_Operation = false;
            DeleteFormGrades.Show();
            DeleteFormGrades.BringToFront();
    
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            //Siakad_Menu FormMenuSiakad = new Siakad_Menu();


        }
    }
}
