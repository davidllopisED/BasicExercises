using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
       
            
            if (Lion.Checked)
            {
                ChoosenAnimals.Text = ChoosenAnimals.Text + Lion.Text;
            }
            if (Tiger.Checked)
            {
                ChoosenAnimals.Text = ChoosenAnimals.Text + Tiger.Text;
            } 
            if (Eagle.Checked)
            {
                ChoosenAnimals.Text = ChoosenAnimals.Text + Eagle.Text;
            }
        }
    }
}
