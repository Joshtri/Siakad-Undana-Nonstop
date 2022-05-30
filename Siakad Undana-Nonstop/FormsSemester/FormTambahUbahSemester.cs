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
using System.Data.SqlClient;

namespace Siakad_Undana_Nonstop.FormsSemester
{
    public partial class FormTambahUbahSemester : BaseFormTambahUbah
    {
        public FormTambahUbahSemester()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Semester_Table VALUES(@Id_Semester,@Nama_Semester)", connecting);
            cmd.Parameters.AddWithValue("@Id_Semester", textBoxIdSemester.Text);
            cmd.Parameters.AddWithValue("@Nama_Semester", textBoxNamaSemester.Text);
            

            cmd.ExecuteNonQuery();

            connecting.Close();

            MessageBox.Show("Anda Telah menyimpan Data");
        }
        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            FormDaftarSemester SemesterFormList = new FormDaftarSemester();
            SemesterFormList.Show();
        }
    }
}
