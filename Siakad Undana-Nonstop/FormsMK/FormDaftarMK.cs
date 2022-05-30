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

namespace Siakad_Undana_Nonstop.FormsMK
{
    public partial class FormDaftarMK : BaseForm
    {
        FormTambahUbahMK FormchangeMK;
        FormHapusMK FormsDeleteMK; 
     
        public FormDaftarMK()
        {
            InitializeComponent();

            labelJudul.Text = "Data Mata Kuliah"; 
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (FormchangeMK == null || FormchangeMK.IsDisposed)
            {
                FormchangeMK = new FormTambahUbahMK();
            }

            FormchangeMK.LabelJudulUbahtambah.Text = "Tambah Mata Kuliah";
            FormchangeMK.Adding_Operation = true;
            FormchangeMK.Show();
            FormchangeMK.BringToFront();
            Hide();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (FormchangeMK == null || FormchangeMK.IsDisposed)
            {
                FormchangeMK = new FormTambahUbahMK();
            }

            FormchangeMK.LabelJudulUbahtambah.Text = "Ubah Mata Kuliah";
            FormchangeMK.Adding_Operation = false;
            FormchangeMK.Show();
            FormchangeMK.BringToFront();
            Hide();
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            //Siakad_Menu frm = new Siakad_Menu();
            //frm.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (FormsDeleteMK == null || FormsDeleteMK.IsDisposed)
            {
                FormsDeleteMK = new FormHapusMK();
            }

            FormsDeleteMK.LabelJudulUbahtambah.Text = "Hapus Data Mata Kuliah";
            FormsDeleteMK.Adding_Operation = false;
            FormsDeleteMK.Show();
            FormsDeleteMK.BringToFront();
          
        }

        private void ShowData()
        {

            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Subject_Table", connecting);

            SqlDataAdapter AdapterDate = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterDate.Fill(dt);
            BaseFormdataGridViewData.DataSource = dt;
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowData(); 
        }
    }
}
