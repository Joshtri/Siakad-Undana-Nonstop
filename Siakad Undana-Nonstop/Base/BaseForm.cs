using Siakad_Undana_Nonstop.Entity;
using Siakad_Undana_Nonstop.FormsMahasiswa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Siakad_Undana_Nonstop.Base
{
    public partial class BaseForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg,
                                    IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

       




        //private SqlConnection connecting = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SiakadDB;Integrated Security=True");
        public BaseForm()
        {
            InitializeComponent();
        }

        //public void GetData()
        //{
        //    String querry = $"SELECT * FROM StudentTable {connecting}";
        //    connecting.Open();

        //    SqlDataAdapter sda = new SqlDataAdapter(querry, connecting);

        //    DataTable dtable = new DataTable();

        //    sda.Fill(dtable);

        //    BaseFormdataGridViewData.DataSource = dtable;
        //    connecting.Close();

        //}


        private void BaseFormdataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected virtual void buttonClose_Click(object sender, EventArgs e)
        {
            Siakad_Menu FormMenuSiakad = new Siakad_Menu();
           
            Close();
            FormMenuSiakad.Show();
           
           
        }

        protected virtual void TitleBars_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString(@"hh:mm:ss");
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
        
        }

        protected virtual void BaseFormdataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected virtual void BaseFormdataGridViewData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clock_Click(object sender, EventArgs e)
        {

        }
    }
}
