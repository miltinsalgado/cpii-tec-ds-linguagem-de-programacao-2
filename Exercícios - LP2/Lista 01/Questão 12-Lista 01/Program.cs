using System;

namespace Questão_12_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 12-Lista 01");

            Console.WriteLine("Entre com um número:\t");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("1");
            else if (num < 0)
                Console.WriteLine("-1");
            else
                Console.WriteLine("0");

            Console.ReadLine();
        }
    }
}
