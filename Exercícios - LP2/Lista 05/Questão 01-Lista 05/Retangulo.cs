using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_01_Lista_05
{
    class Retangulo
    {
        public int Altura;
        public int Largura;

        public int CalcularPerimetro()
        {
            return Altura * 2 + Largura * 2;
        }
        public int CalcularArea()
        {
            return Altura * Largura;
        }
    }
}