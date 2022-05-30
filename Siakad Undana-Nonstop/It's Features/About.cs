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

namespace Siakad_Undana_Nonstop.It_s_Features
{
    public partial class About : BaseAbout
    {
        public About()
        {
            InitializeComponent();
            LabelJudulUbahtambah.Text = "About";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();

            Siakad_Menu frmSiakad = new Siakad_Menu();
            frmSiakad.Show();
        }
    }
}
