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

namespace Siakad_Undana_Nonstop.FormsMK
{
    public partial class FormTambahUbahMK : BaseFormTambahUbah
    {
            FormDaftarMK ListMKForm = new FormDaftarMK();
        public FormTambahUbahMK()
        {
            InitializeComponent();
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);

            ListMKForm.Show(); 
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Subject_Table VALUES(@Nama_MK,@Kode_MK,@Deskripsi,@Total_SKS)", connecting);
            cmd.Parameters.AddWithValue("@Nama_MK", textBoxNamaMk.Text);
            cmd.Parameters.AddWithValue("@Kode_MK", textBoxKodeMk.Text);
            cmd.Parameters.AddWithValue("@Deskripsi", textBoxDesripsiMk.Text);
            cmd.Parameters.AddWithValue("@Total_SKS", textBoxJumlahSks.Text);
     

            cmd.ExecuteNonQuery();

            connecting.Close();

            MessageBox.Show("Anda Telah menyimpan Data");
            Hide();

            ListMKForm.Show(); 

        }
    }
}
