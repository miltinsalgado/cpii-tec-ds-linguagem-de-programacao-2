using System;

namespace Questão_32_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 32-Lista 01");

            Console.WriteLine("Entre com a altura da pirâmide:");
            int altura = Convert.ToInt32(Console.ReadLine());
            int cont = 0;

            for (int i = 1; i <= altura; i++)
            {
                if (i == 1)
                    cont = i;
                    
                for (int j = altura - i; j > 0; j--)
                    Console.Write(" ");

                for (int k = i; k > 0; k--)
                {
                    Console.Write(cont + " ");
                    cont++;
                }
                
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
        
    }
}