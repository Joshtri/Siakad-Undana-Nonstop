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
using System.Data.SqlClient;


namespace Siakad_Undana_Nonstop.FormsMahasiswa
{
    public partial class FormDaftarMahasiswa : BaseForm
    {
        FormTambahUbahMahasiswa Formchangestudent;
        FormHapusMahasiswa FormDeletedstudent;
        FormUbahMahasiswa FormUpdateStudent; 
        // public static List<Students> ListMahasiswa = new List<Students>();

        
        public FormDaftarMahasiswa()
        {
            InitializeComponent();
            labelJudul.Text = "Data Mahasiswa";
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
            Hide();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (FormUpdateStudent == null || FormUpdateStudent.IsDisposed)
            {
                FormUpdateStudent = new FormUbahMahasiswa();
            }

            FormUpdateStudent.LabelJudulUbahtambah.Text = "Ubah Mahasiswa";
            FormUpdateStudent.Adding_Operation = false;
            FormUpdateStudent.Show();
            FormUpdateStudent.BringToFront();
            Hide();
        }

        private void ShowData()
        {

            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Student_Table", connecting);

            SqlDataAdapter AdapterDate = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterDate.Fill(dt);
            BaseFormdataGridViewData.DataSource = dt;
        }

       

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        public void BindGrid()
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student_Table", connecting);
            SqlDataAdapter AdapterData = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterData.Fill(dt);

            BaseFormdataGridViewData.DataSource = dt;
        }
        public void ButtonHapus_Click(object sender, EventArgs e)
        {
            if (FormDeletedstudent == null || FormDeletedstudent.IsDisposed)
            {
                FormDeletedstudent = new FormHapusMahasiswa();
            }

            FormDeletedstudent.LabelJudulUbahtambah.Text = "Hapus Data Mahasiswa";
            FormDeletedstudent.Adding_Operation = false;
            FormDeletedstudent.Show();
            FormDeletedstudent.BringToFront();
           

          
        }

        private void FormDaftarMahasiswa_Activated(object sender, EventArgs e)
        {
         
        }

        private void FormDaftarMahasiswa_Load(object sender, EventArgs e)
        {
 
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
        }

       


        protected override void BaseFormdataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

    }
}
