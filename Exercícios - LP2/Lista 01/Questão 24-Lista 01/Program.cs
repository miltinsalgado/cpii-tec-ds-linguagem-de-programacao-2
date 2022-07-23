using System;

namespace Questão_24_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 24-Lista 01");

            int resultado = 0;
            for(int i=1;i<=10;i++)
            {
                resultado = resultado + i;
            }
            Console.WriteLine("Os 10 primeiros número naturais são: 1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine("A soma destes números vale " + resultado + ".");

            Console.ReadLine();
        }
    }
}
