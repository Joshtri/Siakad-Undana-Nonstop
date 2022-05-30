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
namespace Siakad_Undana_Nonstop.FormsNilai
{
    public partial class FormTambahUbahNilai : BaseFormTambahUbah
    {
        public FormTambahUbahNilai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Grade_Table VALUES(@id_semester,@kode_mk,@nim,@nilai_angka,@nilai_huruf)", connecting);
            cmd.Parameters.AddWithValue("@id_semester", textBoxIdSemester.Text);
            cmd.Parameters.AddWithValue("@kode_mk", textBoxKodeMk.Text);
            cmd.Parameters.AddWithValue("@nim", textBoxNim.Text);
            cmd.Parameters.AddWithValue("@nilai_angka", textBoxNilaiAngka.Text);
            cmd.Parameters.AddWithValue("@nilai_huruf", textBoxNilaiHuruf.Text);


            cmd.ExecuteNonQuery();

            connecting.Close();

            MessageBox.Show("Anda Telah menyimpan Data");
            Hide();
            FormDaftarNilai frmnilai = new FormDaftarNilai();

            frmnilai.Show();
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            FormDaftarNilai frmnilai = new FormDaftarNilai();

            frmnilai.Show();
        }
    }
}
