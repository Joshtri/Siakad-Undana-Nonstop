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

namespace Siakad_Undana_Nonstop.Base
{ 
    public partial class BaseFormTambahUbah : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg,
                                    IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public bool Adding_Operation = true; 
        public BaseFormTambahUbah()
        {
            InitializeComponent();
        }

       

        protected virtual void buttonClose_Click(object sender, EventArgs e)
        {
          
            Close();
        }

        public virtual void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual void BtnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        public virtual void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        protected virtual void TitleBars_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }
    }
}
