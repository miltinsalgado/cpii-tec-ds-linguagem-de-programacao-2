using System;

namespace Questão_25_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 25-Lista 01");

            Console.WriteLine("Entre com um número:\t");
            int num = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;
            Console.WriteLine("Os " + num + " primeiros números naturais são:");
            for(int i=1;i<=num;i++)
            {
                resultado = resultado + i;
                Console.WriteLine(i);
            }
            Console.WriteLine("A soma dos " + num + " primeiros números naturais vale " + resultado);
            Console.ReadLine();
            
        }
    }
}
