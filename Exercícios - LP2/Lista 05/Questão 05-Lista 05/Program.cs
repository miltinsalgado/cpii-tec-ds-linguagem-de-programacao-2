using System;

namespace Questão_05_Lista_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 05-Lista 05");

            Data data = new Data();

            Console.WriteLine("Digite o número do primeiro dia:");
            data.dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número do primeiro mes:");
            data.mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número do primeiro ano:");
            data.ano = Convert.ToInt32(Console.ReadLine());

            Data data2 = new Data();

            Console.WriteLine("Digite o número do segundo dia:");
            data2.dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número do segundo mes:");
            data2.mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número do segundo ano:");
            data2.ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + data.Descrever());
            Console.WriteLine("\n" + data2.Descrever());

            bool verificacao_bissexto = data.EhBissexto();

            if (verificacao_bissexto == true)
                Console.WriteLine("O ano de " + data.ano + " é bissexto.");
            else 
                Console.WriteLine("O ano de " + data.ano + " não é bissexto.");

            int verificacao_comparacao = data.CompararDatas(data2);

            if (verificacao_comparacao == 1)
                Console.WriteLine("A data do parâmetro é maior que a data do objeto chamador");
            else if (verificacao_comparacao == 0)
                Console.WriteLine("A data do parâmetro é menor que a data do objeto chamador");
            else
                Console.WriteLine("A data do parâmetro é igual a data do objeto chamador");

            Console.ReadLine();
        }
    }
}