using Siakad_Undana_Nonstop.Base;
using Siakad_Undana_Nonstop.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siakad_Undana_Nonstop.FormsMK
{
    public partial class FormDaftarMK : BaseForm
    {
        FormTambahUbahMK FormchangeMK; 
        private static List<Subjects> ListSubjects = new List<Subjects>();
        public FormDaftarMK()
        {
            InitializeComponent();

            labelJudul.Text = "Daftar Mata Kuliah";
            for (int i = 0; i < 10; i++)
            {
                Subjects newMKul = new Subjects();
                newMKul.SubjectCode = "123456789" + (i + 1).ToString();
                newMKul.SubjectsName = "23" + (i + 1).ToString();
                newMKul.Description = "000" + (i + 1).ToString();
                newMKul.SKSTotal = 00;

                ListSubjects.Add(newMKul); // untuk masuukan data ke list
            }
                BaseFormdataGridViewData.DataSource = ListSubjects;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (FormchangeMK == null || FormchangeMK.IsDisposed)
            {
                FormchangeMK = new FormTambahUbahMK();
            }

            FormchangeMK.LabelJudulUbahtambah.Text = "Tambah Mata Kuliah";
            FormchangeMK.Adding_Operation = true;
            FormchangeMK.Show();
            FormchangeMK.BringToFront();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (FormchangeMK == null || FormchangeMK.IsDisposed)
            {
                FormchangeMK = new FormTambahUbahMK();
            }

            FormchangeMK.LabelJudulUbahtambah.Text = "Ubah Mata Kuliah";
            FormchangeMK.Adding_Operation = false;
            FormchangeMK.Show();
            FormchangeMK.BringToFront();
        }
    }
}
