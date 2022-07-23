using System;

namespace Questão_30_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 30-Lista 01");

            Console.WriteLine("Entre com o número de termos:");
            int termos = Convert.ToInt32(Console.ReadLine());
            int soma = 0;
            Console.WriteLine("Os " + termos + " primeiros números ímpares são:");
            for (int i = 1; i <= termos; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                    soma += i;
                }
                else
                    termos++;
            }
            Console.WriteLine("\nA soma desses números vale: " + soma);
            
            Console.ReadLine();
        }
    }
}
