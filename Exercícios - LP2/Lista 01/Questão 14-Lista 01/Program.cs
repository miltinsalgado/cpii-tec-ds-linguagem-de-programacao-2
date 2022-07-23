using System;

namespace Questão_14_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 14-Lista 01");

            Console.WriteLine("Entre com a posição X do ponto:\t");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com a posição Y do ponto:\t");
            int y = Convert.ToInt32(Console.ReadLine());

            if((x > 0) && (y >0))
            {
                Console.WriteLine("O ponto (" + x + "," + y + ") se encontra no primeiro quadrante.");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("O ponto (" + x + "," + y + ") se encontra no segundo quadrante.");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("O ponto (" + x + "," + y + ") se encontra no terceiro quadrante.");
            }
            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine("O ponto (" + x + "," + y + ") se encontra no quarto quadrante.");
            }
            else if ((x == 0) && (y != 0))
            {
                Console.WriteLine("O ponto (" + x + "," + y + ") se encontra no plano PI'.");
            }
            else if ((x != 0) && (y == 0))
            {
                Console.WriteLine("O ponto (" + x + "," + y + ") se encontra no plano PI.");
            }

            Console.ReadLine();
        }
    }
}
