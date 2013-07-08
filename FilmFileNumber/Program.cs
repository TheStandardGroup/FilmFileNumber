using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FilmFileNumber
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
            Form1 frm1 = new Form1();
            frm1.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(frm1);
            //Application.Run(new Form1());
        }
    }
}
