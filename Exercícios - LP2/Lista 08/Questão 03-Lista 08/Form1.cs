using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_03_Lista_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bas = Convert.ToDouble(textBox1.Text);
            double exp = Convert.ToDouble(textBox2.Text);
            double pot = Math.Pow(bas, exp);

            label6.Text = Convert.ToString(bas + "^" + exp);
            textBox3.Text = Convert.ToString(pot);
        }
    }
}
