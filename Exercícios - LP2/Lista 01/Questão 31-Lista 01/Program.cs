using System;

namespace Questão_31_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 31-Lista 01");

            Console.WriteLine("Entre com a altura do triângulo:");
            int altura = Convert.ToInt32(Console.ReadLine());
            //string s1 = "";
            for(int i = 1; i <= altura; i++)
            {
                //s1 += "*";
                //Console.WriteLine(s1);
                for(int k = i; k > 0; k--)
                {
                    Console.Write("*");
                } 
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
