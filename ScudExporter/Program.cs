using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScudExporter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DataService serv = new DataService();
            frmMain form = new frmMain();
            Presenter presenter = new Presenter( form );

            Application.Run(form);
        }
    }
}
