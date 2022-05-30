using Siakad_Undana_Nonstop.Base;
using Siakad_Undana_Nonstop.Entity;
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
    public partial class FormTambahUbahMahasiswa : BaseFormTambahUbah
    {

        
        public FormTambahUbahMahasiswa()
        {
            InitializeComponent();
        }

            
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
          
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open(); 

            SqlCommand cmd = new SqlCommand("INSERT INTO Student_Table VALUES(@Name,@NIM,@JK,@DateYear,@Angkatan)", connecting);
            cmd.Parameters.AddWithValue("@Name", textBoxNama.Text);
            cmd.Parameters.AddWithValue("@NIM", textBoxNIM.Text);
            cmd.Parameters.AddWithValue("@JK", textBoxJK.Text);
            cmd.Parameters.AddWithValue("@DateYear", textBoxTanggalLahir.Text);
            cmd.Parameters.AddWithValue("@Angkatan", textBoxAngkatan.Text);

            cmd.ExecuteNonQuery();

            connecting.Close(); 

            MessageBox.Show("Anda Telah menyimpan Data");

        }
        public override void BtnMax_Click(object sender, EventArgs e)
        {
            base.BtnMax_Click(sender, e);
        }

        public override void BtnMin_Click(object sender, EventArgs e)
        {
            base.BtnMin_Click(sender, e);
        }
        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            FormDaftarMahasiswa daftarMahasiswa = new FormDaftarMahasiswa();

            daftarMahasiswa.Show();
        }

        
    }
}
