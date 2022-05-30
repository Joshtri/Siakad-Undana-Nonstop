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
    public partial class FormHapusSemester : BaseFormTambahUbah
    {
        FormDaftarSemester SemesterListForm = new FormDaftarSemester();
        public FormHapusSemester()
        {
            InitializeComponent();
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            SemesterListForm.Show(); 
             
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");

            connecting.Open();

            SqlCommand cmd = new SqlCommand("DELETE Semester_Table WHERE Id_Semester=@Id_Semester", connecting);
            cmd.Parameters.AddWithValue("@Id_Semester", textBoxIdSemester.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Telah Terhapus");
            Hide();

            SemesterListForm.Show();
        }
    }
}
