using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_do_Miltin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Feito por Milton Salgado Leandro | Turma: IN-210 | Professor: João Lagôas

        // Criação das variáveis de instância (dígitos e operação).
        private double dig_1 = 0, dig_2 = 0;
        private char opr = ' ';

        // Método de limpeza da calculadora

        private void limpeza_Total()
        {
            dig_1 = 0;
            dig_2 = 0;
            opr = ' ';
            tela_calc.Clear();
            tela_calc.Text = "0";
        }

        // Métodos de verificação de tela (string nula ou zero) para atribuição de variáveis sem erro.
        private void tela_calc_Verifica_Nulo(string texto_tela, char digito)
        {
            if (texto_tela == "" && digito == '2')
                dig_2 = dig_1;

            else if (texto_tela != "" && digito == '1')
                dig_1 = Convert.ToDouble(texto_tela);

            else if (texto_tela != "" && digito == '2')
                dig_2 = Convert.ToDouble(texto_tela);
        }

        private string tela_calc_Verifica_Zero(string texto_tela, string num_botao)
        {
            if (texto_tela == "0")
            {
                if (num_botao == "π")
                {
                    texto_tela = Convert.ToString(Math.PI);
                    return texto_tela;
                }
                else if (num_botao == "e")
                {
                    texto_tela = Convert.ToString(Math.E);
                    return texto_tela;
                }
                texto_tela = num_botao;
                return texto_tela;
            }
            else
            {
                if (num_botao == "π")
                {
                    texto_tela = Convert.ToString(Math.PI);
                    return texto_tela;
                }
                else if (num_botao == "e")
                {
                    texto_tela = Convert.ToString(Math.E);
                    return texto_tela;
                }
                texto_tela += num_botao;
                return texto_tela;
            }
        }

        // Métodos "click" dos botões numéricos que colocam o número do botão na tela da calculadora.
        private void num_1_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_1.Text);
        }

        private void num_2_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_2.Text);
        }

        private void num_3_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_3.Text);
        }

        private void num_4_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_4.Text);
        }

        private void num_5_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_5.Text);
        }

        private void num_6_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_6.Text);
        }

        private void num_7_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_7.Text);
        }

        private void num_8_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_8.Text);
        }

        private void num_9_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_9.Text);
        }

        private void num_0_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_0.Text);
        }

        private void num_pi_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_pi.Text);
        }
        private void num_e_Click(object sender, EventArgs e)
        {
            tela_calc.Text = tela_calc_Verifica_Zero(tela_calc.Text, num_e.Text);
        }

        // Método "click" do botão "C" (clear) que chama o método limpeza_Total().
        private void sinal_canc_Click(object sender, EventArgs e)
        {
            limpeza_Total();
        }

        // Criação dos métodos "click" dos operadores matemáticos simples (+|-|x|÷).

        // Método "click" de adição que pega o valor no texto da tela e o armazena em uma variável.
        // Então ele indica a string da operação, e por fim limpa a tela.
        private void sinal_adic_Click(object sender, EventArgs e)
        { 
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            opr = '+';
            tela_calc.Clear();
        }

        // Método "click" de subtração que pega o valor no texto da tela e o armazena em uma variável.
        // Então ele indica a string da operação, e por fim limpa a tela.
        private void sinal_subt_Click(object sender, EventArgs e)
        {
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            opr = '-';
            tela_calc.Clear();
        }

        // Método "click" de multiplicação que pega o valor no texto da tela e o armazena em uma variável.
        // Então ele indica a string da operação, e por fim limpa a tela.
        private void sinal_mult_Click(object sender, EventArgs e)
        {
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            opr = 'x';
            tela_calc.Clear();
        }

        // Método "click" de divisão que pega o valor no texto da tela e o armazena em uma variável.
        // Então ele indica a string da operação, e por fim limpa a tela.
        private void sinal_divi_Click(object sender, EventArgs e)
        {
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            opr = '÷';
            tela_calc.Clear();
        }

        // Método "click" de potênciação que pega o valor no texto da tela e o armazena em uma variável.
        // Então ele indica a string da operação, e por fim limpa a tela.
        private void sinal_pote_Click(object sender, EventArgs e)
        {
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            opr = '^';
            tela_calc.Clear();
        }

        // Método "click" de radiciação que pega o valor no texto da tela e o armazena em uma variável.
        // Então ele indica a string da operação, e por fim limpa a tela.
        private void sinal_raiz_Click(object sender, EventArgs e)
        {
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            opr = '√';
            tela_calc.Clear();
        }

        // Criação dos métodos "click" de símbolos, operações matemáticas especiais e de funções da calculadora adicionais.

        // Método "click" do sinal de vírgula que permite se trabalhar com números fracionários.
        private void sinal_virg_Click(object sender, EventArgs e)
        {
            if (tela_calc.Text.Contains(",") == false)
                tela_calc.Text += sinal_virg.Text;
        }

        // Método "click" do cálculo de fatorial, com restrições matemáticas.
        private void sinal_fato_Click(object sender, EventArgs e)
        {
            opr = ' ';
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            int fatorial = 0;

            if (dig_1 < 0)
            {
                MessageBox.Show("Números negativos não possuem fatorial. \nLimpando a calculadora. \nPara continuar, clique em OK", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpeza_Total();
            }
            else
            {
                fatorial = 1;
                for (int i = 1; i <= dig_1; i++)
                    fatorial *= i;

                tela_calc.Text = Convert.ToString(fatorial);
            }
        }

        // Método "click" com o mesmo funcionamento do "delete" na calculadora do Windows.
        private void sinal_del_Click(object sender, EventArgs e)
        {
            if (tela_calc.Text.Length == 1)
                tela_calc.Text = "0";

            else if (tela_calc.Text.Length > 1 && tela_calc.Text.Contains("-") == false)
                tela_calc.Text = tela_calc.Text.Remove(tela_calc.Text.Length-1);

            else if (tela_calc.Text.Length == 2 && tela_calc.Text.Contains("-") == true)
                tela_calc.Text = "0";

            else if (tela_calc.Text.Length > 2 && tela_calc.Text.Contains("-") == true)
                tela_calc.Text = tela_calc.Text.Remove(tela_calc.Text.Length - 1);
        }

        // Método "click" que troca o sinal do número (positivo para negativo e vice-versa).
        private void troca_sinal_Click(object sender, EventArgs e)
        {
            if (tela_calc.Text != "" && tela_calc.Text != "0" && tela_calc.Text.Contains("-") == true)
                tela_calc.Text = tela_calc.Text.Remove(0, 1);

            else if (tela_calc.Text != "" && tela_calc.Text != "0" && tela_calc.Text.Contains("-") == false)
                tela_calc.Text = String.Concat("-", tela_calc.Text);
        }

        // Métodos "click" de operações trigonométricas simples (sen|cos|tan), logaritmo na base 10, potência de 10 e divisão de um pelo número na tela.

        private void sinal_sin_Click(object sender, EventArgs e)
        {
            opr = ' ';
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            double sin = 0;

            if (dig_1 == 30)
                sin = Math.Round(Math.Sin(dig_1 * (Math.PI / 180)), 1);
            else
                sin = Math.Sin(dig_1 * (Math.PI / 180));

            tela_calc.Text = Convert.ToString(sin);
        }

        private void sinal_cos_Click(object sender, EventArgs e)
        {
            opr = ' ';
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            double cos = 0;

            if (dig_1 == 60)
                cos = Math.Round(Math.Cos(dig_1 * (Math.PI / 180)), 1);
            else if (dig_1 == 90)
                cos = 0;
            else
                cos = Math.Cos(dig_1 * (Math.PI / 180));

            tela_calc.Text = Convert.ToString(cos);
        }

        private void sinal_tan_Click(object sender, EventArgs e)
        {
            opr = ' ';
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            double tan = 0;

            if (dig_1 == 90)
            {
                MessageBox.Show("Impossível calcular a tangente de 90°. \nLimpando a calculadora. \nPara continuar, clique em OK", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpeza_Total();
            }
            else if (dig_1 == 45)
                tan = 1;
            else
                tan = Math.Tan(dig_1 * (Math.PI / 180));
                
            tela_calc.Text = Convert.ToString(tan);
        }

        private void sinal_log_Click(object sender, EventArgs e)
        {
            opr = ' ';
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            if (dig_1 < 0)
            {
                MessageBox.Show("Números negativos possuem logaritmo imaginário. \nLimpando a calculadora. \nPara continuar, clique em OK", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpeza_Total();
            }
            else
            {
                double logaritmo = Math.Log10(dig_1);
                tela_calc.Text = Convert.ToString(logaritmo);
            }
        }

        private void sinal_pot10_Click(object sender, EventArgs e)
        {
            opr = ' ';
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');
            double potencia_10 = Math.Pow(10, dig_1);
            tela_calc.Text = Convert.ToString(potencia_10);
        }

        private void sinal_1div_Click(object sender, EventArgs e)
        {
            opr = ' ';
            tela_calc_Verifica_Nulo(tela_calc.Text, '1');

            if (dig_1 == 0)
            {
                MessageBox.Show("Não é possível dividir por zero. \nLimpando a calculadora. \nPara continuar, clique em OK", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpeza_Total();
            }
            else
            {
                double numdiv_1 = 1 / dig_1;
                tela_calc.Text = Convert.ToString(numdiv_1);
            }
        }

        // Método "click" para o cálculo e a exibição do resultado, a partir da operação iniciada acima (executa apenas uma operação, substituindo o sinal operatório pelo último clicado).
        private void sinal_igual_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case '+':
                    tela_calc_Verifica_Nulo(tela_calc.Text, '2');
                    double soma = dig_1 + dig_2;
                    tela_calc.Text = Convert.ToString(soma);
                    opr = ' ';
                    break;

                case '-':
                    tela_calc_Verifica_Nulo(tela_calc.Text, '2');
                    double diferenca = dig_1 - dig_2;
                    tela_calc.Text = Convert.ToString(diferenca);
                    opr = ' ';
                    break;

                case 'x':
                    tela_calc_Verifica_Nulo(tela_calc.Text, '2');
                    double produto = dig_1 * dig_2;
                    tela_calc.Text = Convert.ToString(produto);
                    opr = ' ';
                    break;

                case '÷':
                    tela_calc_Verifica_Nulo(tela_calc.Text, '2');
                    if (dig_2 == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero. \nLimpando a calculadora. \nPara continuar, clique em OK", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpeza_Total();
                        break;
                    }
                    double quociente = dig_1 / dig_2;
                    tela_calc.Text = Convert.ToString(quociente);
                    opr = ' ';
                    break;

                case '^':
                    tela_calc_Verifica_Nulo(tela_calc.Text, '2');
                    double potencia = Math.Pow(dig_1, dig_2);
                    if (Convert.ToString(potencia) == "NaN")
                    {
                        MessageBox.Show("Números negativos não possuem raiz com índice par. \nLimpando a calculadora. \nPara continuar, clique em OK", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpeza_Total();
                        break;
                    }
                    tela_calc.Text = Convert.ToString(potencia);
                    opr = ' ';
                    break;

                case '√':
                    tela_calc_Verifica_Nulo(tela_calc.Text, '2');
                    double raiz = 0;
                    if (dig_1 < 0 && dig_2 % 2 == 0)
                    {
                        MessageBox.Show("Números negativos não possuem raiz com índice par. \nLimpando a calculadora. \nPara continuar, clique em OK", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpeza_Total();
                        break;
                    }
                    else if (dig_1 < 0 && dig_2 % 2 == 1)
                    {
                        double dig_aux = dig_1 * -1;
                        raiz = Math.Pow(dig_aux, 1 / dig_2);
                        tela_calc.Text = Convert.ToString(raiz * -1);
                        break;
                    }
                    raiz = Math.Pow(dig_1, 1/dig_2);
                    tela_calc.Text = Convert.ToString(raiz);
                    opr = ' ';
                    break;

                default:
                    if (tela_calc.Text[tela_calc.Text.Length-1] == ',')
                        tela_calc.Text = tela_calc.Text.Remove(tela_calc.Text.Length-1);
                    break;
            }
        }
    }
}
