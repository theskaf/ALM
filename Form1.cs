using ALM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.Media;



namespace ALM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            using (SplashScreen ssc = new SplashScreen())
            {
                ssc.ShowDialog();
            }
            InitializeComponent();
        }



        private const int CP_NOCLOSE_BUTTON = 0x200; //     override the CreateParams property in our Form with modified create flags: disable the Close button on the form
        protected override CreateParams CreateParams //     override the CreateParams property in our Form with modified create flags: disable the Close button on the form
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } //                                                override the CreateParams property in our Form with modified create flags: disable the Close button on the form



        private void toolStripMenuItem1_Click(object sender, EventArgs e) //New Game
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) //Settings - About
        {
            this.WindowState = FormWindowState.Minimized;
            frmSettingsAbout setFrm = new frmSettingsAbout();
            setFrm.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Exit
        {
            doSomeShitAndThenCloseApp();
        }



        public void doSomeShitAndThenCloseApp()
        {
            //some shit
            Environment.Exit(0);
        }


    }
}
