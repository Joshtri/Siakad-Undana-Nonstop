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
using Siakad_Undana_Nonstop.Entity;
using System.Data.SqlClient;

namespace Siakad_Undana_Nonstop.FormsNilai
{
    public partial class FormDaftarNilai : BaseForm
    {
        FormTambahUbahNilai FormchangeGrades;
        FormHapusNilai DeleteFormGrades;
        FormUbahNilai FormUpdateGrades;
       
        public FormDaftarNilai()
        {
            InitializeComponent();

            labelJudul.Text = "Daftar Nilai";
           
           // BaseFormdataGridViewData.DataSource = Listgrades;
        }

        public void BindGrid()
        {
            SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Grade_Table", connecting);
            SqlDataAdapter AdapterData = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterData.Fill(dt);

            BaseFormdataGridViewData.DataSource = dt;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (FormchangeGrades == null || FormchangeGrades.IsDisposed)
            {
                FormchangeGrades = new FormTambahUbahNilai();
            }

            FormchangeGrades.LabelJudulUbahtambah.Text = "Tambah Nilai";
            FormchangeGrades.Adding_Operation = true;
            FormchangeGrades.Show();
            FormchangeGrades.BringToFront();
            Hide();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (FormUpdateGrades == null || FormUpdateGrades.IsDisposed)
            {
                FormUpdateGrades = new FormUbahNilai();
            }

            FormUpdateGrades.LabelJudulUbahtambah.Text = "Ubah Nilai";
            FormUpdateGrades.Adding_Operation = false;
            FormUpdateGrades.Show();
            FormUpdateGrades.BringToFront();
            Hide();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (DeleteFormGrades == null || DeleteFormGrades.IsDisposed)
            {
                DeleteFormGrades = new FormHapusNilai();
            }

            DeleteFormGrades.LabelJudulUbahtambah.Text = "Hapus Data Nilai";
            DeleteFormGrades.Adding_Operation = false;
            DeleteFormGrades.Show();
            DeleteFormGrades.BringToFront();

    
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            base.buttonClose_Click(sender, e);
            //Siakad_Menu FormMenuSiakad = new Siakad_Menu();


        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
