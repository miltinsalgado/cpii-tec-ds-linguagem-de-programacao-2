using System;

namespace Questão_34_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 34-Lista 01");

            Console.WriteLine("Digite o número de termos da série:");
            double termos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double serie = 0;
            int cont = 1;
            int fatorial = 0;

            for(int i = 1; i <= termos; i++)
            {
                cont *= 2;
                for (int j = cont; j > 0; j--)
                {
                    if (j == cont)
                        fatorial = cont;
                    else
                        fatorial *= j;
                }
                if (i == 1)
                    serie = (1 - Math.Pow(x, cont)) / fatorial;
                else if (i % 2 == 0)
                    serie += (1 - Math.Pow(x, cont)) / fatorial;
                else
                    serie -= (1 - Math.Pow(x, cont)) / fatorial;
            }
            Console.WriteLine(serie);
            Console.ReadLine();
        }
    }
}
