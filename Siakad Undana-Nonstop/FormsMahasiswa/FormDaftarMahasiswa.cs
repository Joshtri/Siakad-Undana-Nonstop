using Siakad_Undana_Nonstop.Base;
using Siakad_Undana_Nonstop.Entity;
using Siakad_Undana_Nonstop.FormsMahasiswa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siakad_Undana_Nonstop.FormsMahasiswa
{
    public partial class FormDaftarMahasiswa : BaseForm
    {
        FormTambahUbahMahasiswa Formchangestudent;

        Students StudentClick = null;
        static List<Students> ListStudents = new List<Students>();
        public FormDaftarMahasiswa()
        {
            InitializeComponent();

            labelJudul.Text = "Daftar Mahasiswa";
            for (int i = 0; i < 10; i++)
            {
                Students newMahasiswa = new Students();
                newMahasiswa.Name = "123456789" + i.ToString();
                newMahasiswa.Age = "10" + i.ToString();
                newMahasiswa.NIM = "2006080010" + i.ToString();
                newMahasiswa.DateYear = "23" + i.ToString();

               
    
                ListStudents.Add(newMahasiswa);
            }
            BaseFormdataGridViewData.DataSource = ListStudents;

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
           

            if (Formchangestudent == null || Formchangestudent.IsDisposed)
            {
                Formchangestudent = new FormTambahUbahMahasiswa();
            }

            Formchangestudent.LabelJudulUbahtambah.Text = "Tambah Mahasiswa";
            Formchangestudent.Adding_Operation = true;
            Formchangestudent.Show();
            Formchangestudent.BringToFront();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (Formchangestudent == null || Formchangestudent.IsDisposed)
            {
                Formchangestudent = new FormTambahUbahMahasiswa();
            }

            Formchangestudent.LabelJudulUbahtambah.Text = "Ubah Mahasiswa";
            Formchangestudent.Adding_Operation = false;
            Formchangestudent.Show();
            Formchangestudent.BringToFront();
        }

       

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            BaseFormdataGridViewData.DataSource = null;
            BaseFormdataGridViewData.DataSource = ListStudents;
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {


            if (BaseFormdataGridViewData.DataSource != null)
            {
                FormDaftarMahasiswa.ListStudents.Remove(StudentClick);
            }

            BaseFormdataGridViewData.DataSource = null;
            BaseFormdataGridViewData.DataSource = ListStudents;
        }

        private void FormDaftarMahasiswa_Activated(object sender, EventArgs e)
        {
            buttonRefresh.PerformClick();
        }

        //private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var nilaiCell = dataGridViewData.Rows[e.RowIndex].Cells[0].Value;

        //    if (nilaiCell != null)
        //    {
        //        var isiCell = nilaiCell.ToString();

        //        StudentClick = ListStudents.Find(x => x.NIM == isiCell);

        //    }
        //}

        
    }
}
