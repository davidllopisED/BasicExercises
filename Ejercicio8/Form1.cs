using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("David");
            listBox1.Items.Add("Juan");
            listBox1.Items.Add("Maria");
            listBox1.Items.Add("Jorge");
            listBox1.Items.Add("Ignacio");
            listBox1.Items.Add("Laura");
            
        }

        private void Classrom2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("Marta");
            listBox1.Items.Add("Pablo");
            listBox1.Items.Add("Ismael");
            listBox1.Items.Add("Andrea");
            listBox1.Items.Add("Alex");
            listBox1.Items.Add("Melodi");
          
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
