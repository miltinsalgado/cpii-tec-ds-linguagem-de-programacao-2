using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_03_Lista_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palavra = textBox1.Text.ToLower().Trim();

            if (palavra == strrev(palavra))
                label2.Text = "É palíndromo!";
            else
                label2.Text = "Não é palíndromo!";
        }

        private string strrev(string p)
        {
            string palavra_rev = "";
            for(int i = p.Length-1; i >= 0; i--)
            {
                palavra_rev += p[i];
            }
            return palavra_rev;
        }
    }
}
