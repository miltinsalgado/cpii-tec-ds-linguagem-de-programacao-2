using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_03_Lista_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void atualizarIMC()
        {
            decimal altura = numericUpDown1.Value;
            decimal peso = numericUpDown2.Value;
            decimal resultado = Convert.ToDecimal(Convert.ToDouble(peso) / Math.Pow(Convert.ToDouble(altura), 2));
            resultado_IMC.Value = resultado;
        }

        public void atualizarSituação()
        {
            decimal resultado = resultado_IMC.Value;
            if (resultado < 17)
                Situação.Text = "Muito abaixo do peso";
            else if (resultado >= 17 && resultado <= 18.49m)
                Situação.Text = "Abaixo do peso";
            else if (resultado >= 18.49m && resultado <= 24.99m)
                Situação.Text = "Saudável";
            else if (resultado >= 25 && resultado <= 29.99m)
                Situação.Text = "Acima do peso";
            else if (resultado >= 30 && resultado <= 34.99m)
                Situação.Text = "Obesidade I";
            else if (resultado >= 35 && resultado <= 39.99m)
                Situação.Text = "Obesidade II (severa)";
            else
                Situação.Text = "Obesidade III (mórbida)";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            atualizarIMC();
            atualizarSituação();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            atualizarIMC();
            atualizarSituação();
        }
    }
}
