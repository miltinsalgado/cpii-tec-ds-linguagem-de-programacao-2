using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Insira algum ano na sequencia!");
                return;
            }

            // Todo o método gira em torno da ideia de que: se houve uma mudança de par->impar ou impar->par, então a gente deve armazenar o tamanho do segmento
            // Para tornar a solução genérica e sem se preocupar com par->impar ou impar->par, podemos entender que nosso algoritmo vai apenas verificar mudanças
            // Essa sugestão evita precisarmos tratar de casos particulares com ifs (o que muitos alunos fizeram!)

            // Inicialmente iremos percorrer todos os anos que estão armazenados na propriedade Items da ListBox
            // Se for um número ímpar, iremos adicionar a letra C à string percurso, se for par, iremos adicionar a letra B
            string percurso = "";
            foreach (decimal ano in listBox1.Items)
            {
                if (IsOdd(ano)) percurso += "C";
                else percurso += "B";
            }
            // Iremos adicionar um caractere x no final da string percurso. Poderia ser qualquer caractere diferente de C ou B
            // Isso se faz necessário para sabermos que haverá uma mudança no final da string SEM precisar inserir mais um if(final do percurso...)
            // Mais uma vez, essa sugestão evita que tenhamos que tratar casos particulares com ifs
            percurso += "x";

            List<int> tamSegmts = new List<int>();
            int tamSeg = 0;
            for (int i = 0; i < percurso.Length - 1; i++)
            {
                tamSeg++;
                // Se houve uma mudança, então temos que armazenar o tamanho do segmento percorrido
                if (percurso[i] != percurso[i + 1])
                {
                    // Se a lista de segmentos não está vazia e o tamanho do segmento atual é diferente de qualquer segmento na lista de segmentos, então já concluímos que a seq é não alternante.
                    if(tamSegmts.Count != 0 && !tamSegmts.Contains(tamSeg))
                    {
                        textBox1.Text = "Não alternante!";
                        return;
                    }
                    // Adiciona o tamanho do último segmento na lista
                    tamSegmts.Add(tamSeg);
                    // Começa a contar o tamanho do próximo segmento
                    tamSeg = 0;
                }
            }

            textBox1.Text = tamSegmts[0] + "-alternante";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (IsOdd(numericUpDown1.Value))
                label2.Text = "Ano ìmpar";
            else
                label2.Text = "Ano par";
        }

        private bool IsOdd(decimal number)
        {
            if (number % 2 != 0)
                return true;
            else
                return false;
        }
    }
}
