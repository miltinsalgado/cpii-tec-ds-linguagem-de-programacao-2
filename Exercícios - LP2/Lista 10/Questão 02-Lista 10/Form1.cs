using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_02_Lista_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox_text.Text;

            string texto_invertido = Texto.Inverter(texto);
            textBox_inv_text.Text = texto_invertido;

            bool verifica_palindromo = Texto.EhPalindromo(texto);
            if (verifica_palindromo == true)
                textBox_palin.Text = "Sim";
            else
                textBox_palin.Text = "Não";

            int num_vogais = Texto.ContarVogais(texto);
            textBox_vogal.Text = Convert.ToString(num_vogais);
        }
    }
}
