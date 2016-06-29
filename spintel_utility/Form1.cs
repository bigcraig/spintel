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
    }
}
