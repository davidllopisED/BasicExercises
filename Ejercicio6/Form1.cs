using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Red.Checked)
            {
                ChoosenColor.BackColor = Color.Red;
            }
            if (Blue.Checked)
            {
                ChoosenColor.BackColor = Color.Blue;
            }
            if (White.Checked)
            {
                ChoosenColor.BackColor = Color.White;
            }
        }

        private void ChoosenColor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
