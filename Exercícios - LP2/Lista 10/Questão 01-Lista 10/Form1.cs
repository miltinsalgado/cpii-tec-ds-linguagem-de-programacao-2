using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_01_Lista_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(entrada.Value);

            int fatorial = Matemática.Fatorial(valor);
            valor_fatorial.Text = Convert.ToString(fatorial);
            label_fatorial.Text = string.Concat("Fatorial (" + Convert.ToString(valor) + "!)");

            bool verifica_par = Matemática.EhPar(valor);
            if (verifica_par == true)
                check_par.Text = "Sim";
            else
                check_par.Text = "Não";

            bool verifica_primo = Matemática.EhPrimo(valor);          
            if (verifica_primo == true)
                check_primo.Text = "Sim";
            else
                check_primo.Text = "Não";
            
            lista_num_primo.Text = string.Concat("Todos os primos menores que " + Convert.ToString(valor));
            Listagem_Primos(valor);
        }

        private void Listagem_Primos(int valor)
        {
            listagem.Clear();
            List<int> Lista_Primos = new List<int>();
            for (int i = 2; i < valor; i++)
            {
                if (Matemática.EhPrimo(i) == true)
                    Lista_Primos.Add(i);
            }

            foreach (int num in Lista_Primos)
            {
                if (listagem.Text == "")
                    listagem.Text += Convert.ToString(num);
                else
                    listagem.Text += String.Concat(", " + Convert.ToString(num));
            }
        }
    }
}
