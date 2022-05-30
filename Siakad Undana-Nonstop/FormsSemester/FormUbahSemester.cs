using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siakad_Undana_Nonstop.Base;
using System.Data.SqlClient;

namespace Siakad_Undana_Nonstop.FormsSemester
{
    public partial class FormUbahSemester : BaseFormTambahUbah
    {
        public FormUbahSemester()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Semester_Table SET Nama_Semester=@Nama_Semester WHERE Id_Semester=@Id_Semester", connecting);
            cmd.Parameters.AddWithValue("@Id_Semester", textBoxIdSemester.Text);
            cmd.Parameters.AddWithValue("@Nama_Semester", textBoxNamaSemester.Text);
           


            cmd.ExecuteNonQuery();

            connecting.Close();

            MessageBox.Show("Anda Telah menyimpan Data");
            Hide();
            FormDaftarSemester frmsemester = new FormDaftarSemester();
            frmsemester.Show();
            
        }
        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            FormDaftarSemester frmsemester = new FormDaftarSemester();

            frmsemester.Show(); 
        }
        public void BindGrid()
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Semester_Table", connecting);
            SqlDataAdapter AdapterData = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterData.Fill(dt);

            DataGridSemester.DataSource = dt;
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
