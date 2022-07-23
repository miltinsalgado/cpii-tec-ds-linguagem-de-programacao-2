using System;
using System.Collections.Generic;

namespace Questão_03_Teste_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nome: Milton Salgado Leandro - Turma: IN-210 - Professor: João Lagôas

            Console.WriteLine("Questão 03-Teste 02");

            // Declaração de variáveis
            string percurso = "";
            bool achou = false;
            int altura = 0;
            int cont_picos = 0;
            int altura_maior_pico = 0;
            List<int> Lista_Passos_Picos = new List<int>();

            // Questão 03 - Letra a)
            // Aqui é pedido para que o usuário entre com o percurso,
            // e através do comando Do-While com uma variável auxiliar booleana e de um comando For, o mesmo é verificado.
            // Caso o percurso não seja válido, será pedido para que o usuário digite novamente.
            do
            {
                if (achou == true)
                    Console.WriteLine("A entrada digitada não é válida!");

                Console.WriteLine("Entre com o percurso: ");
                achou = false;
                percurso = Console.ReadLine();
                percurso = percurso.Trim();

                for (int i = 0; i < percurso.Length; i++)
                {
                    if (percurso.ToUpper()[i] != 'C' && percurso.ToUpper()[i] != 'B')
                    {
                        achou = true;
                        break;
                    }
                }      
            } while (achou == true);

            // Questão 03 - Letra c) - Letra d) - Letra e)
            // Aqui temos um comando For para percorrer a string e realizar as seguintes ações:
            // 1 - Calcular em qual altura Link finalizou o percurso, para depois verificar se ele voltou ao nível do mar.
            // 2 - Verificar se Link passou por um pico.
            // 3 - Comparar as alturas dos picos e atribuir o valor da maior altura entre os mesmos para uma variável.
            // 4 - Listar numericamente os passos dados por Link que resultaram num pico.
            for (int i = 0; i < percurso.Length; i++)
            {
                if (percurso.ToUpper()[i] == 'C')
                    altura++;
                else if (percurso.ToUpper()[i] == 'B')
                    altura--;
                if (i != percurso.Length - 1 && percurso.ToUpper()[i] == 'C' && percurso.ToUpper()[i + 1] == 'B')
                {
                    if (altura_maior_pico == 0)
                        altura_maior_pico = altura;
                    if (altura > altura_maior_pico)
                        altura_maior_pico = altura;
                    Lista_Passos_Picos.Add(i);
                    cont_picos++;
                }
            }

            // Questão 03 - Letra b)
            // Aqui serão calculados, listados e impressos os textos com os valores das variáveis obtidos, incluindo a quantidade
            // de passos que Link deu.
            int num_passos = percurso.Length;
            if (altura == 0)
                Console.WriteLine("Link, você retornou ao nível do mar e deu " + num_passos + " passo(s).");
            else
                Console.WriteLine("Link, você não retornou ao nível do mar e deu " + num_passos + " passo(s).");

            Console.WriteLine(cont_picos + " pico(s) foi/foram visitado(s).");
            Console.WriteLine("O ponto de altitude do pico mais alto alcançado foi " + altura_maior_pico + ".");

            for (int i = 0; i < Lista_Passos_Picos.Count; i++)
                Console.WriteLine("O " + (i + 1) + "º pico foi alcançado no passo " + (Lista_Passos_Picos[i] + 1) + ".");

            Console.ReadLine();
        }
    }
}
