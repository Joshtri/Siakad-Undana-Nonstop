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

namespace Siakad_Undana_Nonstop.FormsSemester
{
    public partial class FormDaftarSemester : BaseForm
    {
        FormTambahUbahSemester FormChangesemester;
        private static List<Semester> ListSemesters = new List<Semester>(); 
        public FormDaftarSemester()
        {
            InitializeComponent();

            labelJudul.Text = "Daftar Semester";
            for (int i = 0; i < 10; i++)
            {
                Semester NewSemester = new Semester();
                NewSemester.IdSemester = "123456789" + (i + 1).ToString();
                NewSemester.SemesterName = "23" + (i + 1).ToString();

                ListSemesters.Add(NewSemester); // untuk masuukan data ke list
            }
            //BaseFormdataGridViewData.DataSource = ListSemesters;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (FormChangesemester == null || FormChangesemester.IsDisposed)
            {
                FormChangesemester = new FormTambahUbahSemester();
            }

            FormChangesemester.LabelJudulUbahtambah.Text = "Tambah Semester";
            FormChangesemester.Adding_Operation = true;
            FormChangesemester.Show();
            FormChangesemester.BringToFront();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (FormChangesemester == null || FormChangesemester.IsDisposed)
            {
                FormChangesemester = new FormTambahUbahSemester();
            }

            FormChangesemester.LabelJudulUbahtambah.Text = "Ubah Semester";
            FormChangesemester.Adding_Operation = false;
            FormChangesemester.Show();
            FormChangesemester.BringToFront();
        }
    }
}
