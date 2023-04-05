using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALM
{
    public partial class SplashScreen : Form
    {
        //class level variables, just before public SplashScreen()
        private int count = 10;


        public SplashScreen()
        {
            InitializeComponent();
        }


        private void INFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                INFade.Enabled = false;
                timer1.Enabled = true;
                return;
            }
            this.Opacity += 0.01;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer1.Enabled = false;
                OUTFade.Enabled = true;
                return;
            }
            count -= 1;
        }

        private void OUTFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                OUTFade.Enabled = false;
                this.Close();
                return;
            }
            this.Opacity -= 0.01;
        }


    }
}

/*private void SplashScreen_Shown(object sender, EventArgs e)
{
    System.Windows.Forms.Timer tmr;

    tmr = new System.Windows.Forms.Timer();
    tmr.Interval = 2000;
    tmr.Start();
    tmr.Tick += tmr_Tick;


    void tmr_Tick(object sender, EventArgs e)
    {
        tmr.Stop();
        frmMain mf = new frmMain();
        mf.Show();

        this.Hide();
        //this.Close();
    }
}*/