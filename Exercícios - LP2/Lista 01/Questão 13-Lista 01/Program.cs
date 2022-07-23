using System;

namespace Questão_13_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 13-Lista 01");

            Console.WriteLine("Entre com um número inteiro:\t");
            int num_1= Convert.ToInt32(Console.ReadLine());
            int maior_num = num_1;

            Console.WriteLine("Entre com outro número inteiro:\t");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            if (num_2 > maior_num)
                maior_num = num_2;

            Console.WriteLine("Entre com mais um número inteiro:\t");
            int num_3 = Convert.ToInt32(Console.ReadLine());
            if (num_3 > maior_num)
                maior_num = num_3;

            Console.WriteLine("Primeiro número: " + num_1 + "\nSegundo número: " + num_2 + "\nTerceiro número: " + num_3 + "\n" + maior_num + " é o maior dos números.");

            Console.ReadLine();
        }
    }
}
