using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siakad_Undana_Nonstop.Base
{ 
    public partial class BaseFormTambahUbah : Form
    {
        public bool Adding_Operation = true; 
        public BaseFormTambahUbah()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
