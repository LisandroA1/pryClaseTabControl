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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("estoy en la ficha uno");
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("estoy en la ficha dos");
        }
    }
}
