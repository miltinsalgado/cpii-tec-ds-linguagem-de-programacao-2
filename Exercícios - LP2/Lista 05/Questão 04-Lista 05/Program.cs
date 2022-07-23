using System;

namespace Questão_04_Lista_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 04-Lista 05");

            Data data = new Data();

            Console.WriteLine("Digite o número do dia:");
            data.dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número do mes:");
            data.mes = Convert.ToInt32(Console.ReadLine());

            switch (data.mes)
            {
                case 1:
                    data.nome_mes = "janeiro";
                    break;
                case 2:
                    data.nome_mes = "fevereiro";
                    break;
                case 3:
                    data.nome_mes = "março";
                    break;
                case 4:
                    data.nome_mes = "abril";
                    break;
                case 5:
                    data.nome_mes = "maio";
                    break;
                case 6:
                    data.nome_mes = "junho";
                    break;
                case 7:
                    data.nome_mes = "julho";
                    break;
                case 8:
                    data.nome_mes = "agosto";
                    break;
                case 9:
                    data.nome_mes = "setembro";
                    break;
                case 10:
                    data.nome_mes = "outubro";
                    break;
                case 11:
                    data.nome_mes = "novembro";
                    break;
                case 12:
                    data.nome_mes = "dezembro";
                    break;
            }

            Console.WriteLine("Digite o número do ano:");
            data.ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + data.Descrever());

            bool verificacao = data.EhBissexto();

            if (verificacao == true)
                Console.WriteLine("O ano de " + data.ano + " é bissexto.");
            else 
                Console.WriteLine("O ano de " + data.ano + " não é bissexto.");

            Console.ReadLine();
        }
    }
}
