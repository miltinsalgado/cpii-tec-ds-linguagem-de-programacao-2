using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_02_Lista_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operacao = textBox4.Text.ToLower().Trim();
            switch (operacao)
            {
                case "somar":
                    label1.Text = "+";
                    double parcela_1 = Convert.ToDouble(textBox1.Text);
                    double parcela_2 = Convert.ToDouble(textBox2.Text);
                    double soma = parcela_1 + parcela_2;
                    textBox3.Text = Convert.ToString(soma);
                    break;
                case "subtrair":
                    label1.Text = "-";
                    double minuendo = Convert.ToDouble(textBox1.Text);
                    double subtraendo = Convert.ToDouble(textBox2.Text);
                    double resto = minuendo - subtraendo;
                    textBox3.Text = Convert.ToString(resto);
                    break;
                case "multiplicar":
                    label1.Text = "*";
                    double fator_1 = Convert.ToDouble(textBox1.Text);
                    double fator_2 = Convert.ToDouble(textBox2.Text);
                    double produto = fator_1 * fator_2;
                    textBox3.Text = Convert.ToString(produto);
                    break;
                case "dividir":
                    label1.Text = "/";
                    double dividendo = Convert.ToDouble(textBox1.Text);
                    double divisor = Convert.ToDouble(textBox2.Text);
                    double quociente = dividendo / divisor;
                    textBox3.Text = Convert.ToString(quociente);
                    break;
                default:
                    MessageBox.Show("Operação inválida!");
                    string vazio = "";
                    textBox1.Text = vazio;
                    textBox2.Text = vazio;
                    textBox3.Text = vazio;
                    textBox4.Text = vazio;
                    break;
            }
        }
    }
}
