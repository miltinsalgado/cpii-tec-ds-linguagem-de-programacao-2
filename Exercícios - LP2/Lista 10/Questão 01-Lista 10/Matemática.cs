using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_01_Lista_10
{
    class Matemática
    {
        public static int Fatorial(int num)
        {
            int fatorial = 1;

            for(int i = 1; i <= num; i++)
                fatorial *= i;

            return fatorial;
        }

        public static bool EhPar(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

        public static bool EhPrimo(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i != 1 && i != num && num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
