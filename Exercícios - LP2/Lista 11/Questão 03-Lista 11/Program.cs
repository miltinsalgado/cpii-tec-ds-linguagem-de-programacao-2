using System;
using System.Collections.Generic;

namespace Questão_03_Lista_11
{
    class Program
    {
        public static int kAlternante(List<int> valores)
        {
            int marca_bloco = 0;
            int cont_par = 0;
            int cont_impar = 0;

            for (int j = 0; j < valores.Count; j++)
            {
                if (Convert.ToInt32(valores[j]) % 2 == 0)
                    cont_par++;
                else
                    cont_impar++;
            }

            if (cont_par != cont_impar)
                return 0;
            else
            {
                for (int i = 0; i < valores.Count; i++)
                {
                    if (valores[0] % 2 == 0 && valores[i] % 2 != 0)
                    {
                        marca_bloco = i;
                        break;
                    }
                    else if (valores[0] % 2 != 0 && valores[i] % 2 == 0)
                    {
                        marca_bloco = i;
                        break;
                    }
                }

                for (int j = 0; j < valores.Count; j++)
                {
                    if (j + marca_bloco < valores.Count)
                    {
                        if (valores[j] % 2 == 0 && valores[j + marca_bloco] % 2 == 0)
                            return 0;
                        else if (valores[j] % 2 != 0 && valores[j + marca_bloco] % 2 != 0)
                            return 0;
                    }
                }
                return marca_bloco;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Questão 03-Lista 11");

            List<int> sequencia = new List<int>();
            bool continua = false;
            string confirma = "";
            int num = 0;

            do
            {
                Console.WriteLine("Entre com um número inteiro positivo:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 0)
                {
                    while (num <= 0)
                    {
                        Console.WriteLine("Número digitado inválido");
                        Console.WriteLine("Entre com um número inteiro positivo:");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                }
                sequencia.Add(num);
                Console.WriteLine("Deseja adicionar mais um número?");
                confirma = Console.ReadLine();
                if (confirma.ToUpper().Trim() == "SIM")
                    continua = true;
                else
                    continua = false;
            } while (continua == true);

            string texto_sequencia = "";
            foreach (int numero in sequencia)
                texto_sequencia += numero + " ";

            if (kAlternante(sequencia) == 0)
                Console.WriteLine("A sequência: " + texto_sequencia + "não é alternante.");
            else
                Console.WriteLine("A sequência: " + texto_sequencia + "é " + kAlternante(sequencia) + "-alternante.");

            Console.ReadLine();
        }
    }
}
