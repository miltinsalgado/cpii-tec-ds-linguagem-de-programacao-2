using System;

namespace Questão_09_10_Teste_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nome: Milton Salgado Leandro - Turma: IN-210 - Professor: João Lagôas

            Console.WriteLine("Questões 09-10-Teste 01");

            Console.WriteLine("\nEstudando função linear!");

            Console.WriteLine("OBS 1: O valor de A deve ser diferente de 0 para que a função linear não seja constante!");
            Console.WriteLine("OBS 2: Caso o valor de A inserido seja 0, será pedido para que seja inserido novamente um valor para A.");
            Console.WriteLine("Favor, digite os valores de A e B:");

            double CoefAng = Convert.ToDouble(Console.ReadLine());
            double CoefLin = Convert.ToDouble(Console.ReadLine());

            if (CoefAng == 0)
            {
                do
                {
                    Console.WriteLine("Valor de A inválido! Por favor, digite um novo valor diferente de 0!");
                    CoefAng = Convert.ToDouble(Console.ReadLine());
                } while (CoefAng == 0);
            }

            FuncaoLinear funcao = new FuncaoLinear(CoefAng, CoefLin);

            Console.WriteLine("\nObjeto criado!");
            Console.WriteLine("Valor de A: {0}", funcao.GetA());
            Console.WriteLine("Valor de B: {0}", funcao.B);

            Console.WriteLine("\nSua função: {0}", funcao.Descrever());
            Console.WriteLine("Inclinação da reta: {0}", funcao.Inclinacao());
            Console.WriteLine("Raiz: {0}", funcao.Raiz());

            Console.ReadLine();
        }
    }
}
