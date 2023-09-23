using BusinessApp.BL;
using BusinessApp.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string name;
        public static string password;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserDL.ReadUserDataFromFile();
            ProductDL.ReadProductDataFromFile();
            Application.Run(new frmLogin());
        }
    }
}
