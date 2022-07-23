using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_01_Lista_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal soma = 0;
            decimal resto = 0;
            decimal quociente = 0;
            decimal produto = 0;

            if (adição.Checked == true)
            {
                soma = num_1.Value + num_2.Value;
                resultado.Value = soma;
            }
            if (subtração.Checked == true)
            {
                resto = num_1.Value - num_2.Value;
                resultado.Value = resto;
            }
            if (divisão.Checked == true)
            {
                if (num_2.Value == 0)
                    MessageBox.Show("Não é possível dividir por zero!");
                else
                {
                    quociente = num_1.Value / num_2.Value;
                    resultado.Value = quociente;
                }
            }
            if (multiplicação.Checked == true)
            {
                produto = num_1.Value * num_2.Value;
                resultado.Value = produto;
            }
        }
    }
}
