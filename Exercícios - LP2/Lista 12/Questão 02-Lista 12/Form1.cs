using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_02_Lista_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal matricula = Matricula.Value;
            string nome = Nome.Text;
            string curso = Curso.Text;
            decimal mensalidade = Mensalidade.Value;
            int desconto = 0;

            if (desc_3.Checked == true)
                desconto = 3;
            if (desc_5.Checked == true)
                desconto = 5;
            if (desc_7.Checked == true)
                desconto = 7;
            if (desc_10.Checked == true)
                desconto = 10;

            decimal mensalidade_desc = mensalidade - ((mensalidade * desconto) / 100);
            string cadastro = matricula.ToString() + " - " + curso + " - " + nome + " - " + mensalidade_desc.ToString("C");

            listBox1.Items.Add(cadastro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
