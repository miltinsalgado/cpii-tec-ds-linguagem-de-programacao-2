using System;

namespace Questão_23_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 23-Lista 01");

            Console.WriteLine("\tMENU\n");
            Console.WriteLine("Digite:\n1-Somar\n2-Subtrair\n3-Multiplicar\n4-Dividir");
            Console.WriteLine("Qual será a operação desejada?");

            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Digite um número:\t");
                    double parcela_1  = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite outro número:\t");
                    double parcela_2 = Convert.ToDouble(Console.ReadLine());
                    double soma = parcela_1 + parcela_2;
                    Console.WriteLine("A soma de " + parcela_1 + " com " + parcela_2 + " é igual a " + soma + ".");
                    break;
                case 2:
                    Console.WriteLine("Digite um número:\t");
                    double minuendo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite outro número:\t");
                    double subtraendo = Convert.ToDouble(Console.ReadLine());
                    double diferença = minuendo - subtraendo;
                    Console.WriteLine("A diferença de " + minuendo + " com " + subtraendo + " é igual a " + diferença + ".");
                    break;
                case 3:
                    Console.WriteLine("Digite um número:\t");
                    double multiplicador = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite outro número:\t");
                    double multiplicando = Convert.ToDouble(Console.ReadLine());
                    double produto = multiplicador * multiplicando;
                    Console.WriteLine("O produto de " + multiplicador + " com " + multiplicando + " é igual a " + produto + ".");
                    break;
                case 4:
                    Console.WriteLine("Digite um número:\t");
                    double dividendo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite outro número:\t");
                    double divisor = Convert.ToDouble(Console.ReadLine());
                    double quociente = dividendo / divisor;
                    //int resto = dividendo % divisor;
                    Console.WriteLine("O quociente de " + dividendo + " com " + divisor + " é igual a " + quociente + "." /*+ " e o resto é igual a " + resto*/);
                    break;
                default:
                    Console.WriteLine("Nenhuma opção escolhida, por favor tente novamente");
                    break;
            }
            Console.ReadLine();
        }
    }
}
