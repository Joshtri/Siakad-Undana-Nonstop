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

namespace Siakad_Undana_Nonstop.FormsMK
{
    public partial class FormUbahMK : BaseFormTambahUbah
    {
        public FormUbahMK()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Subject_Table SET Nama_MK=@Nama_MK,Deskripsi=@Deskripsi,Total_SKS=@Total_SKS WHERE Kode_MK=@Kode_MK", connecting);
            cmd.Parameters.AddWithValue("@Nama_MK", textBoxNamaMk.Text);
            cmd.Parameters.AddWithValue("@Kode_MK", textBoxKodeMk.Text);
            cmd.Parameters.AddWithValue("@Deskripsi", textBoxDesripsiMk.Text);
            cmd.Parameters.AddWithValue("@Total_SKS", textBoxJumlahSks.Text);


            cmd.ExecuteNonQuery();

            connecting.Close();

            MessageBox.Show("Anda Telah menyimpan Data");
            Hide();

            FormDaftarMK frmMK = new FormDaftarMK();
            frmMK.Show();

            
        }
        public void BindGrid()
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Subject_Table", connecting);
            SqlDataAdapter AdapterData = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterData.Fill(dt);

            DataGridMK.DataSource = dt;
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);

            FormDaftarMK formMK = new FormDaftarMK();
            formMK.Show();
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
