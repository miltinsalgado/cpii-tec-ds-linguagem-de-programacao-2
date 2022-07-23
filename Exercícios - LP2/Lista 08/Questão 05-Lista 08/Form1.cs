using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_05_Lista_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_R_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Value_A.Text);
            double b = Convert.ToDouble(Value_B.Text);

            double raiz = 0;

            if (b == 0)
                raiz = b / a;
            else
                raiz = -b / a;

            Value_R.Text = Convert.ToString(raiz);
            TFuncaoLinear.Text = "y = " + Value_A.Text + "x + " + Value_B.Text;
        }

        private void Calc_I_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Value_A.Text);
            double b = Convert.ToDouble(Value_B.Text);
            double x = Convert.ToDouble(Value_X.Text);

            double i = (a * x) + b;
            Value_I.Text = Convert.ToString(i);
            TFuncaoLinear.Text = "y = " + Value_A.Text + "x + " + Value_B.Text; 
        }
    }
}
