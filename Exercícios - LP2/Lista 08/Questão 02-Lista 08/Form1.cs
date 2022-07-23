using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_02_Lista_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double parcela_1 = Convert.ToDouble(textBox1.Text);
            double parcela_2 = Convert.ToDouble(textBox2.Text);
            double soma = parcela_1 + parcela_2;
            textBox3.Text = Convert.ToString(soma);
        }
    }
}
