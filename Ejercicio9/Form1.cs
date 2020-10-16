using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Even_Click(object sender, EventArgs e)
        {
            ComboBox.Items.Clear();
            for (int i =1;i<=10;i++)
            {
                if (i % 2 == 0)
                {
                    ComboBox.Items.Add(i.ToString());
                }
            }
        }

        private void Odd_Click(object sender, EventArgs e)
        {
            ComboBox.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    ComboBox.Items.Add(i.ToString());
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = ComboBox.Text;
        }
    }
}
