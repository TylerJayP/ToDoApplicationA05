using System;
using System.Windows.Forms;

namespace ToDoApplication
{
    static class Program
    {
        public static Homepage home;
        
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new Homepage();
            home.IntializeList("CurrentTasks.txt");
            home.IntializeList("UpcomingTasks.txt");
            home.IntializeList("PreviousTasks.txt");
            Application.Run(home);
            OnApplicationExit();
        }

        /// <summary>
        /// Saves the changes to our file once we close the application
        /// </summary>
        private static void OnApplicationExit()
        {
            home.PrintToFile("CurrentTasks.txt");
            home.PrintToFile("UpcomingTasks.txt");
            home.PrintToFile("PreviousTasks.txt");
        }
    }
}
