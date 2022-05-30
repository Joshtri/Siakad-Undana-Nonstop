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

namespace Siakad_Undana_Nonstop.FormsMahasiswa
{
    public partial class FormUbahMahasiswa : BaseFormTambahUbah
    {
        public FormUbahMahasiswa()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Student_Table SET Name=@Name, JK=@JK, DateYear=@DateYear, Angkatan=@Angkatan WHERE NIM = @NIM", connecting);
            cmd.Parameters.AddWithValue("@Name", textBoxNama.Text);
            cmd.Parameters.AddWithValue("@NIM", textBoxNIM.Text);
            cmd.Parameters.AddWithValue("@JK", textBoxJK.Text);
            cmd.Parameters.AddWithValue("@DateYear", textBoxTanggalLahir.Text);
            cmd.Parameters.AddWithValue("@Angkatan", textBoxAngkatan.Text);


            cmd.ExecuteNonQuery();
            connecting.Close();

            MessageBox.Show("Anda Telah menyimpan Data");
            Hide();

            FormDaftarMahasiswa frmdtrmhs = new FormDaftarMahasiswa();
            frmdtrmhs.Show();

        }
        public void BindGrid()
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student_Table", connecting);
            SqlDataAdapter AdapterData = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterData.Fill(dt);

            dataGridMhs.DataSource = dt;
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);

            FormDaftarMahasiswa frmMahasiswa = new FormDaftarMahasiswa();

            frmMahasiswa.Show();
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
