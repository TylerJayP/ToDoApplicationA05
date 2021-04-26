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
            home.intializeList("CurrentTasks.txt");
            home.intializeList("UpcomingTasks.txt");
            home.intializeList("PreviousTasks.txt");
            Application.Run(home);
            OnApplicationExit();
        }

        /// <summary>
        /// Saving the changes to our file once we close the application
        /// </summary>
        private static void OnApplicationExit()
        {
            // When the application is exiting, write the application data to the
            // user file and close it.
            home.printingToFile("CurrentTasks.txt");
            home.printingToFile("UpcomingTasks.txt");
            home.printingToFile("PreviousTasks.txt");
        }
    }
}
