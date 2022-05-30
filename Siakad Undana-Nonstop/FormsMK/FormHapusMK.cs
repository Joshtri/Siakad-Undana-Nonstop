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
    public partial class FormHapusMK : BaseFormTambahUbah
    {
            FormDaftarMK ListMKForm = new FormDaftarMK();
        public FormHapusMK()
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

            SqlCommand cmd = new SqlCommand("DELETE Student_Table WHERE Kode_MK=@Kode_MK", connecting);
            cmd.Parameters.AddWithValue("@Kode_MK", textBoxKodeMk.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Telah Terhapus");
            Hide();

            ListMKForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
