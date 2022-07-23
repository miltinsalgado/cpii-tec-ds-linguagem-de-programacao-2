using System;

namespace Questão_06_Lista_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 06-Lista 06");

            Console.WriteLine("Função afim: y = a*x + b");
            FuncaoLinear funcao = new FuncaoLinear();

            Console.WriteLine("Digite o valor de a:");
            funcao.CoefAng = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de b:");
            funcao.CoefLin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nf(" + x + ")" + " = y = " + funcao.CoefAng + " * " + x + " + " + funcao.CoefLin + " = " + funcao.CalcularY(x));
            Console.WriteLine("raiz = " + funcao.CalcularRaiz());

            Console.ReadLine();
        }
    }
}
