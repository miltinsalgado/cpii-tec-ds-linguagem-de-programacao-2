using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_01_Lista_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor_X1 = numX1.Value;
            decimal valor_Y1 = numY1.Value;
            decimal valor_X2 = numX2.Value;
            decimal valor_Y2 = numY2.Value;

            Ponto ponto_1 = new Ponto(Convert.ToDouble(valor_X1), Convert.ToDouble(valor_Y1));
            Ponto ponto_2 = new Ponto(Convert.ToDouble(valor_X2), Convert.ToDouble(valor_Y2));

            decimal distancia = Convert.ToDecimal(Ponto.Distancia(ponto_1, ponto_2));
            numDist.Value = distancia;

            string função_linear = "";
            função_linear = "y = " + Ponto.Reta(ponto_1, ponto_2)[0] + "x + " + Ponto.Reta(ponto_1, ponto_2)[1];
            labelReta.Text = função_linear;
        }
    }
}
