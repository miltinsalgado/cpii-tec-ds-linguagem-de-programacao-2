using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_06_Lista_05
{
    class FuncaoLinear
    {
        public double CoefAng;
        public double CoefLin;

        public double CalcularY(double x)
        {
            return CoefAng * x + CoefLin;
        }

        public double CalcularRaiz()
        {
            return -CoefLin / CoefAng;
        }
    }
}
