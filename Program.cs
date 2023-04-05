using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace ALM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font, see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
            //Application.Run(new SplashScreen());
        }
    }
}




/*
namespace ALM
{
    static class Program
    {
        // Create an instance of the splashscreen 
        static SplashScreen splashscreen;

        /// <summary> 
        /// The main entry point for the application. 
        /// </summary> 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain()); 
            //-------------- End of original lines. --------------// 

            // Initialize and show splashscreen. Say the welcome message. 
            splashscreen = new SplashScreen();
            splashscreen.Show();
            //splashscreen.SayWelcome();

            // Create an instance of frmMain and hook into shown and closed events. 
            frmMain main = new frmMain();
            main.Shown += main_Shown;
            main.FormClosed += main_FormClosed;

            Application.Run(main);
        }

        static void main_FormClosed(object sender, FormClosedEventArgs e) //private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Hide the calling form  
            Form form = sender as Form;
            form.Hide();

            // Show the splash screen and say goodbye. 
            splashscreen.Show();
            //splashscreen.SayGoodBye();
            System.Threading.Thread.Sleep(3000);
        }

        static void main_Shown(object sender, EventArgs e) //private void frmMain_Shown(object sender, EventArgs e)
        {
            // Hide the splashscreen. 
            splashscreen.Hide();
        }
    }
}
*/


