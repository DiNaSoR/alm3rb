using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Converter4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(Application application)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            application.Run(new Form1());
        }
    }
}