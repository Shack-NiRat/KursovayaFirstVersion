using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngouriMath;
using AngouriMath.Extensions;
using AngouriMath.Convenience;
using AngouriMath.Core;
using RungeKutta;
using System.Runtime.InteropServices;
using System.Runtime;

namespace MainForm
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            Root.Text = "\u221A";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RKMethod rng = new RKMethod(Double.Parse(Y0.Text), Double.Parse(X0.Text), Equation.Text,0.1,Double.Parse(XEnd.Text));

            FillResult(rng);
        }

        private void FillResult(RKMethod obj)
        {
            List<double> y = new List<double>();
            List<double> x = new List<double>();
            y = obj.CreateFunction();
            x = obj.CreateXFunc();
            Result.ColumnCount = 2;
            Result.RowCount = y.Count;
            for(int i = 0; i < y.Count; i++)
            {
                Result[0, i].Value = y[i];
                Result[1, i].Value = x[i];

            }

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("{BACKSPACE}");
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equation.Text = "";
            X0.Text = "";
            Y0.Text = "";
        }

        private void X0_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!Char.IsDigit(number)&& number!=  44 && number != 8) e.Handled = true;
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            Equation.Text += "+";
        }

        private void Share_Click(object sender, EventArgs e)
        {
            Equation.Text += @"\";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            Equation.Text += "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Equation.Text += "*";
        }

        private void Root_Click(object sender, EventArgs e)
        {
            Equation.Text += "sqrt()";
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            Equation.Text += "cos()";
        }

        private void Degree_Click(object sender, EventArgs e)
        {
            Equation.Text += "^";
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            Equation.Text += "sin()";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Equation.Text += "tan()";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equation.Text += "cotan()";
        }

        private void Arccos_Click(object sender, EventArgs e)
        {
            Equation.Text += "arccos()";
        }

        private void Arctan_Click(object sender, EventArgs e)
        {
            Equation.Text += "arctan()";
        }

        private void Log_Click(object sender, EventArgs e)
        {
            Equation.Text += "Log(2,)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Equation.Text += "Ln()";
        }

        private void Arccotan_Click(object sender, EventArgs e)
        {
            Equation.Text += "Arccotan()";
        }

        private void Arcsin_Click(object sender, EventArgs e)
        {
            Equation.Text += "arcsin()";
        }

        private void Equation_TextChanged(object sender, EventArgs e)
        {
            XStart.Text = X0.Text;
        }
    }
}
