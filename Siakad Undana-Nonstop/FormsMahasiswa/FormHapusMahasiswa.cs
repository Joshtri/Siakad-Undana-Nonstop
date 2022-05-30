using System;
using Siakad_Undana_Nonstop.Base;
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
    public partial class FormHapusMahasiswa : BaseFormTambahUbah
    {
        FormDaftarMahasiswa daftarMahasiswa = new FormDaftarMahasiswa();
        public FormHapusMahasiswa()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
           SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");

            connecting.Open();

            SqlCommand cmd = new SqlCommand("DELETE Student_Table WHERE NIM=@NIM",connecting);
            cmd.Parameters.AddWithValue("@NIM", textBoxNIM.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Telah Terhapus");
            Hide();

            

        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);


            daftarMahasiswa.Show();
        }






    }
}
