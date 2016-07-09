using SimpleBrowser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spintel_utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var nf4v = new NF4V();
           // nf4v.nf4Vsetup();
           
        }

        private void configureModem_Click(object sender, EventArgs e)
        {
            var nf4v = new NF4V();
            nf4v.nf4Vsetup();
        }

        private void voipButton_Click(object sender, EventArgs e)
        {
            var nf4v = new NF4V();
            Browser nf10wModem = new Browser();
             nf4v.initialiseModem(nf10wModem);
            nf4v.configureVoip(nf10wModem,"sip.iboss.com.au", "sip.iboss.com.au", "09802390000610", "F2P66PB3");
        }
    }
}
