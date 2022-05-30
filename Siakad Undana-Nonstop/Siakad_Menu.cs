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
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Siakad_Undana_Nonstop.It_s_Features;


namespace Siakad_Undana_Nonstop
{
    public partial class Siakad_Menu : Form
    {
        //anggap saja ini form 2
        public static Siakad_Menu instance;
        public Label labl1; 

        public Siakad_Menu()
        {
            InitializeComponent();
            instance = this;
            labl1 = GreetingUser; 
        }

        

        private FormDaftarMahasiswa FormDftrMahas;
        private FormDaftarMK FormDftrMatkul;
        private FormDaftarNilai FormDftrNli;
        private FormDaftarSemester FormDftrSmstr;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg,
                                    IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString(@"hh:mm:ss");
            //Dates.Text = DateTime.Now.ToString(@"ddd,dd:MM:yyyy");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FormDftrMahas == null || FormDftrMahas.IsDisposed)
            {
                FormDftrMahas = new FormDaftarMahasiswa();
            }
            

           
            FormDftrMahas.Show();
            FormDftrMahas.BringToFront();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (FormDftrSmstr == null || FormDftrSmstr.IsDisposed)
            {
                FormDftrSmstr = new FormDaftarSemester ();
            }
         
       
            FormDftrSmstr.Show();
            FormDftrSmstr.BringToFront();
            Hide();

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
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (FormDftrMatkul == null || FormDftrMatkul.IsDisposed)
            {
                FormDftrMatkul = new FormDaftarMK();
            }
            
            FormDftrMatkul.Show();
            FormDftrMatkul.BringToFront();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void GreetingUser_Click(object sender, EventArgs e)
        {
            //LoginOfficer loginofficer = new LoginOfficer();

            //string Name = loginofficer.NameTextbox.Text;
            //string Password = loginofficer.PasswordBox.Text;



            //var FindName = $"Selamat Datang {Name}";
            //GreetingUser.Text = FindName;
            //GreetingUser.Show();
            

            //String querry = "SELECT * FROM Table_1 WHERE username = '" + Name + "' AND password =  '" + Password+ "'";
            //SqlDataAdapter sda = new SqlDataAdapter(querry, connecting);




        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized; 

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        private void TitleBars_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        private void Siakad_Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void About_Click(object sender, EventArgs e)
        {
            About frmabout = new About();

            frmabout.Show();
            Hide();
        }
    }
}
