using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_02_Lista_05
{
    class Circulo
    {
        public int Raio;
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio,2);
        }
    }
}
