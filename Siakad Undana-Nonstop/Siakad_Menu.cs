using Siakad_Undana_Nonstop.FormsMahasiswa;
using Siakad_Undana_Nonstop.FormsMK;
using Siakad_Undana_Nonstop.FormsNilai;
using Siakad_Undana_Nonstop.FormsSemester;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siakad_Undana_Nonstop
{
    public partial class Siakad_Menu : Form
    {

        private FormDaftarMahasiswa FormDftrMahas;
        private FormDaftarMK FormDftrMatkul;
        private FormDaftarNilai FormDftrNli;
        private FormDaftarSemester FormDftrSmstr;

        public Siakad_Menu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString(@"hh:mm:ss");
            Dates.Text = DateTime.Now.ToString(@"ddd,dd:MM:yyyy");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FormDftrMahas == null || FormDftrMahas.IsDisposed)
            {
                FormDftrMahas = new FormDaftarMahasiswa();
            }

            FormDftrMahas.Show();
            FormDftrMahas.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (FormDftrSmstr == null || FormDftrSmstr.IsDisposed)
            {
                FormDftrSmstr = new FormDaftarSemester ();
            }

            FormDftrSmstr.Show();
            FormDftrSmstr.BringToFront();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormDftrNli == null || FormDftrNli.IsDisposed)
            {
                FormDftrNli = new FormDaftarNilai();
            }

            FormDftrNli.Show();
            FormDftrNli.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (FormDftrMatkul == null || FormDftrMatkul.IsDisposed)
            {
                FormDftrMatkul = new FormDaftarMK();
            }

            FormDftrMatkul.Show();
            FormDftrMatkul.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
