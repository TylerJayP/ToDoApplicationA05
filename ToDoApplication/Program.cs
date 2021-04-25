using System;
using System.Windows.Forms;

namespace ToDoApplication
{
    static class Program
    {
        public static Homepage home;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new Homepage();
            Application.Run(home);
        }
    }
}
