using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_03_Lista_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal posicao_inicial = value_posic_ini.Value;
            decimal velocidade = value_velo.Value;
            decimal tempo = value_tempo.Value;
            MovimentoUniforme MovUni = new MovimentoUniforme(posicao_inicial, velocidade);

            value_posic_fin.Value = MovUni.PosicaoFinal(tempo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal km_h = value_km_h.Value;
            value_m_s.Value = MovimentoUniforme.ConvertToMpS(km_h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal m_s = value_m_s.Value;
            value_km_h.Value = MovimentoUniforme.ConvertToKMpH(m_s);
        }
    }
}
