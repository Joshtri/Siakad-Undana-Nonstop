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
    public partial class FormHapusNilai : BaseFormTambahUbah
    {
        public FormHapusNilai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");

            connecting.Open();

            SqlCommand cmd = new SqlCommand("DELETE Grade_Table WHERE kode_mk=@kode_mk", connecting);
            cmd.Parameters.AddWithValue("@kode_mk", textBoxKodeMk.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Telah Terhapus");
            Hide();

            //FormDaftarNilai ListNilai = new FormDaftarNilai(); 
            //ListNilai.Show();
        }
    }
}
