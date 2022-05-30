using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siakad_Undana_Nonstop.MainPage;

namespace Siakad_Undana_Nonstop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new MainPages());
            //Application.Run(new menu));

            Application.Run( new Siakad_Menu());
        }
    }
}
