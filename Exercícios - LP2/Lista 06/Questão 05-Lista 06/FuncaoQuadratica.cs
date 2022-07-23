using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_05_Lista_06
{
    class FuncaoQuadratica
    {
        private double A;
        public double B, C;

        public FuncaoQuadratica(double a, double b, double c)
        {
            SetA(a);
            B = b;
            C = c;
        }

        // Criação do metódo setter "SetA" que verifica se "A" recebeu o valor 0 ou não, pois de acordo com o enunciado a função linear NÃO pode ser constante.
        // Caso o valor de "a" seja 0, ele pede para o usuário entrar com um valor válido em um loop while, avaliando sempre se "a" é igual a 0.
        public void SetA(double a)
        {
            if (a != 0)
                A = a;
            else
            {
                while (a == 0)
                {
                    Console.WriteLine("Valor de A inválido! Por favor, digite um novo valor diferente de 0!");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                A = a;
            }
        }

        public double Raiz1()
        {
            double delta = Math.Sqrt(Math.Pow(B, 2) - (4 * A * C));
            return -B + delta  / (2 * A);
        }

        public double Raiz2()
        {
            double delta = Math.Sqrt(Math.Pow(B, 2) - (4 * A * C));
            return -B - delta / (2 * A);
        }

        public double XVertice()
        {
            if (B == 0)
                return B / (2 * A);
            else
                return -B / (2 * A);
        }

        public double YVertice()
        {
            double delta = Math.Sqrt(Math.Pow(B, 2) - (4 * A * C));
            if(delta == 0)
                return delta / (4 * A);
            else
                return -delta / (4 * A);
        }

        public string Concavidade()
        {
            if (A > 0)
                return "para cima";
            else
                return "para baixo";
        }

        public string Descricao()
        {
            if(B > 0 && C > 0)
                return "y=" + A + "x²+" + B + "x+" + C;

            else if (B > 0 && C < 0)
                return "y=" + A + "x²+" + B + "x" + C;

            else if(B < 0 && C > 0)
                return "y=" + A + "x²" + B + "x+" + C;

            else if (B < 0 && C < 0)
                return "y=" + A + "x²" + B + "x" + C;

            else if (B == 0 && C > 0)
                return "y=" + A + "x²+" + "x+" + C;

            else if (B == 0 && C < 0)
                return "y=" + A + "x²+" + "x" + C;

            else if (B > 0 && C == 0)
                return "y=" + A + "x²+" + B + "x";

            else
                return "y=" + A + "x²" + B + "x";
        }
    }
}
