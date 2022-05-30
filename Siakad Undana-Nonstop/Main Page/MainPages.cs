using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siakad_Undana_Nonstop.MainPage
{
    public partial class MainPages : Form
    {
        public MainPages()
        {
            InitializeComponent();
        }

        private void OfficeButtonLogin_Click(object sender, EventArgs e)
        {
            LoginOfficer officer = new LoginOfficer();
            officer.Show();
            Hide();
        }
       

    }
}
