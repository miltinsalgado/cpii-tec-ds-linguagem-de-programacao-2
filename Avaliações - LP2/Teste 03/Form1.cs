using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_03
{
    public partial class Form1 : Form
    {
        // Nome: Milton Salgado Leandro - Turma: IN-210 - Professor: João Lagôas

        // Letra a) Design do formulário.
        public Form1()
        {
            InitializeComponent();
        }

        // Letra b) Método que trata o evento mudança de valor na NumericUpDown.
        private void valor_Ano_ValueChanged(object sender, EventArgs e)
        {
            decimal ano = valor_Ano.Value;
            if (ano % 2 == 0)
                label_Paridade.Text = "Ano Par";
            else
                label_Paridade.Text = "Ano Ímpar";
        }

        // Letra c) Método que trata o evento clique no botão “Inserir”.
        private void button_Inserir_Click(object sender, EventArgs e)
        {
            decimal ano = valor_Ano.Value;
            ListBox_Anos.Items.Add(ano);
        }

        // Letra d) Método que trata o evento clique no botão “Limpar Lista”.
        private void button_Limpar_Lista_Click(object sender, EventArgs e)
        {
            ListBox_Anos.Items.Clear();
            textBox_k_alternante.Text = "";
        }

        // Letra e) Método que trata o evento clique no botão “Avaliar Sequência”.
        private void button_Avaliar_Sequência_Click(object sender, EventArgs e)
        {       
            int valor_sequência= Determinar_Sequência();
            string texto = "";
            if (valor_sequência == 0)
                texto = "Não Alternante!";
            else
                texto = Convert.ToString(valor_sequência) + "-Alternante!";
            textBox_k_alternante.Text = texto;
        }

        // Letra e) Complemento: Método que determina o tipo de sequência (k-alternante ou não alternante).
        // Baseado na minha resolução da Questão 03 da Lista 11
        private int Determinar_Sequência()
        {
            int marca_bloco = 0;
            int cont_par = 0;
            int cont_impar = 0;

            for (int j = 0; j < ListBox_Anos.Items.Count; j++)
            {
                if (Convert.ToInt32(ListBox_Anos.Items[j]) % 2 == 0)
                    cont_par++;
                else
                    cont_impar++;
            }

            if (cont_par != cont_impar)
                return 0;
            else
            {
                for (int i = 0; i < ListBox_Anos.Items.Count; i++)
                {
                    if (Convert.ToInt32(ListBox_Anos.Items[0]) % 2 == 0 && Convert.ToInt32(ListBox_Anos.Items[i]) % 2 != 0)
                    {
                        marca_bloco = i;
                        break;
                    }
                    else if (Convert.ToInt32(ListBox_Anos.Items[0]) % 2 != 0 && Convert.ToInt32(ListBox_Anos.Items[i]) % 2 == 0)
                    {
                        marca_bloco = i;
                        break;
                    }
                }

                for (int j = 0; j < ListBox_Anos.Items.Count; j++)
                {
                    if (j + marca_bloco < ListBox_Anos.Items.Count)
                    {
                        if (Convert.ToInt32(ListBox_Anos.Items[j]) % 2 == 0 && Convert.ToInt32(ListBox_Anos.Items[j + marca_bloco]) % 2 == 0)
                            return 0;
                        else if (Convert.ToInt32(ListBox_Anos.Items[j]) % 2 != 0 && Convert.ToInt32(ListBox_Anos.Items[j + marca_bloco]) % 2 != 0)
                            return 0;
                    }
                }
                return marca_bloco;
            }
        }
    }
}
