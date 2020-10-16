using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChoosenColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox.Text=="Yellow")
            {
                ChoosenColour.Text = "The Choosen colour is Yellow";
            }
            if (ComboBox.Text == "Blue")
            {
                ChoosenColour.Text = "The Choosen colour is Blue";
            }
            if (ComboBox.Text == "Red")
            {
                ChoosenColour.Text = "The Choosen colour is Red";
            }
            if (ComboBox.Text == "Pink")
            {
                ChoosenColour.Text = "The Choosen colour is Pink";
            }
            if (ComboBox.Text == "Green")
            {
                ChoosenColour.Text = "The Choosen colour is Green";
            }
        }
    }
}
