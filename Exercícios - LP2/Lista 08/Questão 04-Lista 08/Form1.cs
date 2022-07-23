using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_04_Lista_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CtoKF_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(N_Celsius.Text);
            double fahrenheit = (1.8 * celsius) + 32;
            double kelvin = celsius + 273.15;

            N_Fahrenheit.Text = Convert.ToString(fahrenheit);
            N_Kelvin.Text = Convert.ToString(kelvin);
        }

        private void FtoKC_Click(object sender, EventArgs e)
        {
            double fahrenheit = Convert.ToDouble(N_Fahrenheit.Text);
            double celsius = ((5 * fahrenheit) - 160) / 9;
            double kelvin = (0.6 * fahrenheit) + 255;

            N_Celsius.Text = Convert.ToString(celsius);
            N_Kelvin.Text = Convert.ToString(kelvin);
        }

        private void KtoCF_Click(object sender, EventArgs e)
        {
            double kelvin = Convert.ToDouble(N_Kelvin.Text);
            double celsius = kelvin - 273.15;
            double fahrenheit = (1.8 * kelvin) - 459.4;

            N_Celsius.Text = Convert.ToString(celsius);
            N_Fahrenheit.Text = Convert.ToString(fahrenheit);
        }
    }
}
