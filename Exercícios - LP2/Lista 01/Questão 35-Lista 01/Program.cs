using System;

namespace Questão_35_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 35-Lista 01");

            Console.WriteLine("Digite o número de termos da série:");
            int termos = Convert.ToInt32(Console.ReadLine());
            int serie = 0;
            int soma = 0;
            int seq = 0;
            string cont = "";
            for(int i = 1; i <= termos; i++)
            {
                cont += "1";
                seq = Convert.ToInt32(cont);
                if (i == 1)
                    serie = 9;
                else
                    serie = 9 * seq;
                soma += serie;
            }
            Console.WriteLine(soma);
        }
    }
}
