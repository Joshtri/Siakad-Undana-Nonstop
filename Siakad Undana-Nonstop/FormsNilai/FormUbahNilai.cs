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

namespace Siakad_Undana_Nonstop.FormsNilai
{
    public partial class FormUbahNilai : BaseFormTambahUbah
    {
        public FormUbahNilai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Grade_Table SET id_semester=@id_semester , nim=@nim, nilai_angka=@nilai_angka, nilai_huruf=@nilai_huruf WHERE kode_mk = @kode_mk", connecting);
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

        public void BindGrid()
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Grade_Table", connecting);
            SqlDataAdapter AdapterData = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterData.Fill(dt);

            DataGridNilai.DataSource = dt;
        }
        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            FormDaftarNilai frmnilai = new FormDaftarNilai();

            frmnilai.Show();
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
