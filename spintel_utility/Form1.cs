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
        string sipDomain, sipProxy, sipUser, sipPassword, sipUser2, sipPassword2;

        private void sipDomainText_TextChanged(object sender, EventArgs e)
        {
            sipDomain = sipDomainText.Text;
            sipProxyText.Text = sipDomainText.Text;
        }

        private void sipProxyText_TextChanged(object sender, EventArgs e)
        {
            sipProxy = sipProxyText.Text;
        }

        private void sipUserText_TextChanged(object sender, EventArgs e)
        {
            sipUser = sipUserText.Text;
        }

        private void sipPasswordText_TextChanged(object sender, EventArgs e)
        {
            sipPassword = sipPasswordText.Text;
        }

        private void Status_TextChanged(object sender, EventArgs e)
        {

        }

        private void sipPassword2Text_TextChanged(object sender, EventArgs e)
        {
            sipPassword2 = sipPassword2Text.Text;
        }

        private void eraseLine2_Click(object sender, EventArgs e)
        {
            sipUser2Text.Text = "";
            sipPassword2Text.Text = "";
        }

        private void sipUser2Text_TextChanged(object sender, EventArgs e)
        {
            sipUser2 = sipUser2Text.Text;
        }

        public Form1()
        {
            InitializeComponent();
          //  var nf4v = new NF4V();
           // nf4v.nf4Vsetup();
           
        }

        private void configureModem_Click(object sender, EventArgs e)
        {
            var nf4v = new NF4V();
            nf4v.nf4Vsetup();
            
        }

        private void voipButton_Click(object sender, EventArgs e)
        {
            Status.Text = "VOIP Configfuration in Progress";
            var nf4v = new NF4V();
            Browser nf10wModem = new Browser();
            Status.Text = nf4v.initialiseModem(nf10wModem);
            if (Status.Text == "Configuration in progress")
            {
                nf4v.configureVoip(nf10wModem, sipDomain, sipProxy, sipUser, sipPassword,sipUser2,sipPassword2);
                Status.Text = "VOIP Configured";
                nf10wModem.Close();
            }
        }
    }
}
