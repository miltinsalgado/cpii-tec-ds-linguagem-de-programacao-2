using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_04_Lista_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void atualizarMédia()
        {
            decimal nota1 = numericUpDown1.Value;
            decimal nota2 = numericUpDown2.Value;
            decimal nota3 = numericUpDown3.Value;
            decimal média = ((3 * nota1) + (3 * nota2) + (4 * nota3)) / 10;
            Média.Value = média;
        }

        private void atualizarSituação()
        {
            decimal média = Média.Value;
            if (média >= 7)
                textBox1.Text = "APROVADO";
            else
                textBox1.Text = "PRF";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            atualizarMédia();
            atualizarSituação();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            atualizarMédia();
            atualizarSituação();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            atualizarMédia();
            atualizarSituação();
        }
    }
}
