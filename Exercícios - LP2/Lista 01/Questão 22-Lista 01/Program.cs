using System;

namespace Questão_22_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 22-Lista 01");

            Console.WriteLine("\tMENU\n");
            Console.WriteLine("Digite:\n1-Quadrado\n2-Retângulo\n3-Triângulo\n4-Círculo");
            Console.WriteLine("Qual será a operação desejada?");

            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Digite a medida do lado de um quadrado:\t");
                    double lado_quadrado = Convert.ToDouble(Console.ReadLine());
                    double area_quadrado = Math.Pow(lado_quadrado, 2);
                    Console.WriteLine("A área do quadrado vale " + area_quadrado + ".");
                    break;
                case 2:
                    Console.WriteLine("Digite a medida da base de um retângulo:\t");
                    double base_retangulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a medida da altura de um retângulo:\t");
                    double altura_retangulo = Convert.ToDouble(Console.ReadLine());
                    double area_retangulo = base_retangulo * altura_retangulo;
                    Console.WriteLine("A área do retângulo vale " + area_retangulo + ".");
                    break;
                case 3:
                    Console.WriteLine("Digite a medida da base de um triângulo:\t");
                    double base_triangulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a medida da altura de um triângulo:\t");
                    double altura_triangulo = Convert.ToDouble(Console.ReadLine());
                    double area_triangulo = (base_triangulo * altura_triangulo)/2;
                    Console.WriteLine("A área do triângulo vale " + area_triangulo + ".");
                    break;
                case 4:
                    Console.WriteLine("Digite a medida do raio de um círculo:\t");
                    double raio_circulo= Convert.ToDouble(Console.ReadLine());
                    double PI = 3.14;
                    double area_circulo = Math.Pow(raio_circulo, 2) * PI;
                    Console.WriteLine("A área do círculo vale " + area_circulo + ".");
                    break;
                default:
                    Console.WriteLine("Nenhuma opção escolhida, por favor tente novamente");
                    break;
            }
            Console.ReadLine();
        }
    }
}
