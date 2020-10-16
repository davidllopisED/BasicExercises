using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4a
{
    
    public partial class Form1 : Form
    {
        int comprobar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
                
                if(comprobar==1)
                {
                    int operand1sum, operand2sum, sum;
                    operand1sum = Convert.ToInt32(Operand1.Text);
                    operand2sum = Convert.ToInt32(Operand2.Text);
                    sum = operand1sum + operand2sum;
                    Result.Text = sum.ToString();
                    Operation.Text = "+";
                }
                if (comprobar == 2)
                {
                    int operand1sub, operand2sub, sub;
                    operand1sub = Convert.ToInt32(Operand1.Text);
                    operand2sub = Convert.ToInt32(Operand2.Text);
                    sub = operand1sub - operand2sub;
                    Result.Text = sub.ToString();
                    Operation.Text = "-";
            }
            if (comprobar != 1 && comprobar != 2)
            {
                MessageBox.Show("Please introduce Sum or Substract");
            }

        }

        private void Sum_Click(object sender, EventArgs e)
        {
            comprobar = 1;
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            comprobar = 2;
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
