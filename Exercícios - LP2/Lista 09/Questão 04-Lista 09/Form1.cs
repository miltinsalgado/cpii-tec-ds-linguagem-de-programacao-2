using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_04_Lista_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string nome = name.Text.ToLower();
            double cont_a = 0, cont_e = 0, cont_i = 0, cont_o = 0, cont_u = 0; 

            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i] == 'a')
                    cont_a++;
                else if (nome[i] == 'e')
                    cont_e++;
                else if (nome[i] == 'i')
                    cont_i++;
                else if (nome[i] == 'o')
                    cont_o++;
                else if (nome[i] == 'u')
                    cont_u++;
            }

            vogais_a.Text = Convert.ToString(cont_a);
            vogais_e.Text = Convert.ToString(cont_e);
            vogais_i.Text = Convert.ToString(cont_i);
            vogais_o.Text = Convert.ToString(cont_o);
            vogais_u.Text = Convert.ToString(cont_u);
        }
    }
}
