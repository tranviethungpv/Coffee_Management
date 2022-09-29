using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
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
            Application.Run(new fBill());
            //Hello, I'm Hung1.
            //Hello I'm Hung2.
            //Hello Tu1.
            //Hello i'm Ky.
        }
    }

   
}
