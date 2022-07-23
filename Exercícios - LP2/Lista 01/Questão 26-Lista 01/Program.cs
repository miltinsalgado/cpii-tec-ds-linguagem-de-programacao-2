using System;

namespace Questão_26_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 26-Lista 01");
            
            Console.WriteLine("Entre com os cinco números:\n");
            int num;
            int soma = 0;
            for (int i=1;i<6;i++)
            {
                Console.WriteLine("Número-" + i + ":");
                num = Convert.ToInt32(Console.ReadLine());
                soma = num + soma;
            }
            int media = soma / 5;

            Console.WriteLine("A soma dos números vale:\t" + soma + ".");
            Console.WriteLine("A média dos números vale:\t" + media + ".");

            Console.ReadLine();
        }
    }
}
