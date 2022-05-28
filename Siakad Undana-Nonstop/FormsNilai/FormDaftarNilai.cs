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
        private static List<Grades> Listgrades = new List<Grades>();
        public FormDaftarNilai()
        {
            InitializeComponent();

            labelJudul.Text = "Daftar Nilai";
            for (int i = 0; i < 10; i++)
            {
                Grades NewGrade = new Grades();
                NewGrade.IdSemester = "123456789" + (i + 1).ToString();
                NewGrade.CodeSubject = "23" + (i + 1).ToString();
                NewGrade.Nim = "000" + (i + 1).ToString();
                NewGrade.NumberGrade = 00;
                NewGrade.LetterGrade = "000" + (i + 1).ToString();

                Listgrades.Add(NewGrade); // untuk masuukan data ke list
            }
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
        }
    }
}
