using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTabControl29052023
{
    public partial class frmBarraDeProgreso : Form
    {
        public frmBarraDeProgreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int can = 50000;
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = can;

            for (i = 0; i<can; i++)
            {
                progressBar1.Value = i;
            }
        }
    }
}
