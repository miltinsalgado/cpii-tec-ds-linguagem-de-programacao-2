using System;

namespace Questão_05_Lista_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 05-Lista 06");

            Console.WriteLine("Bem-vindo à calculadora de funções quadráticas!");
            Console.WriteLine("Favor entre com os valores de a, b e c:");
            //Captura dos dados de entrada
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            //Instanciação de um objeto FuncaoQuadratica
            FuncaoQuadratica objFunc = new FuncaoQuadratica(a, b, c);
            Console.WriteLine("O objeto função criado é {0}", objFunc.Descricao());

            //Agora que o objeto foi criado, vamos chamar seus métodos
            Console.WriteLine("O X do vértice vale {0} e o Y do vértice vale {1}",
            objFunc.XVertice(), objFunc.YVertice());
            Console.WriteLine("As raízes da função valem {0} e {1}", objFunc.Raiz1(),
            objFunc.Raiz2());
            Console.WriteLine("A concavidade da função é {0}", objFunc.Concavidade());

            Console.ReadLine();
        }
    }
}
