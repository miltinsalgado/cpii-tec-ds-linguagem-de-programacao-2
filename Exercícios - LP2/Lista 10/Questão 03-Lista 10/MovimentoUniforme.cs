using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_03_Lista_10
{
    class MovimentoUniforme
    {
        public decimal PosicaoInicial = 0;
        public decimal Velocidade = 0;

        public MovimentoUniforme(decimal posIni, decimal vel)
        {
            PosicaoInicial = posIni;
            Velocidade = vel;
        }

        public decimal PosicaoFinal(decimal tempo)
        {
            decimal PosicaoFinal = PosicaoInicial + (Velocidade * tempo);
            return PosicaoFinal;
        }

        public static decimal ConvertToKMpH(decimal mps)
        {
            decimal kmph = mps * 3.6m;
            return kmph;
        }

        public static decimal ConvertToMpS(decimal kmph)
        {
            decimal mps = kmph / 3.6m;
            return mps;
        }
    }
}
