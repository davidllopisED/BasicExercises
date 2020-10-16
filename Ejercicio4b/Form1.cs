using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (listBox.Text=="+")
            {
                int operand1sum, operand2sum, sum;
                operand1sum = Convert.ToInt32(Operand1.Text);
                operand2sum = Convert.ToInt32(Operand2.Text);
                sum = operand1sum + operand2sum;
                Result.Text = sum.ToString();
                Operation.Text = "+";
            }
            if (listBox.Text == "-")
            {
                int operand1sub, operand2sub, sub;
                operand1sub = Convert.ToInt32(Operand1.Text);
                operand2sub = Convert.ToInt32(Operand2.Text);
                sub = operand1sub - operand2sub;
                Result.Text = sub.ToString();
                Operation.Text = "-";
            }
            if (listBox.Text != "+" && listBox.Text != "-")
            {
                MessageBox.Show("Please try Sum or Substract");
            }
        }

        private void Operation1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Sum_Click(object sender, EventArgs e)
        {
            listBox.Text = "+";
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            listBox.Text = "-";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Operand1.Clear();
            Operand2.Clear();
            Operation.Clear();
            Result.Clear();
        }
    }
}
