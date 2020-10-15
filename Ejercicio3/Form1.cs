using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int operand1, operand2, suma;
            operand1 = Convert.ToInt32(Operand1.Text);
            operand2 = Convert.ToInt32(Operand2.Text);
            suma = operand1 + operand2;
            Result.Text = suma.ToString();
        }

        private void Operand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Operand1.Clear();
            Operand2.Clear();
            Result.Clear();
        }
       
    }
}
