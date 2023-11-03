using System;
using System.Windows.Forms;

namespace Pamodoro_Time
{
    static class clsSettings
    {
        public static TimeSpan StudyTime = new TimeSpan(0, 15, 0);
        public static TimeSpan RestTime = new TimeSpan(0, 5, 0);
    }


    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pamodoro());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool SetProcessDPIAware();
    }
}
