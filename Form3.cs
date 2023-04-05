using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALM
{
    public partial class frmSettingsAbout : Form
    {
        public frmSettingsAbout()
        {
            InitializeComponent();
        }

        private void frmSettingsAbout_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
