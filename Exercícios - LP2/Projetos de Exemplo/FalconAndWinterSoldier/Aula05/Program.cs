using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi sam = new Heroi("Falcão", true, 2, 2, 5);
            Heroi bucky = new Heroi("Soldado Invernal", true, 4, 3, 3);

            Batalha arena = new Batalha(sam, bucky);

            while(arena.CombatentesEstaoVivos())
            {
                Console.Clear();
                Console.WriteLine("1. " + sam.DescreverDados() + "\n");
                Console.WriteLine("2. " + bucky.DescreverDados() + "\n");
                Console.WriteLine("Combatente 1, faça seu movimento...");
                string decisao1 = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("1. " + sam.DescreverDados() + "\n");
                Console.WriteLine("2. " + bucky.DescreverDados() + "\n");
                Console.WriteLine("Combatente 2, faça seu movimento...");
                string decisao2 = Console.ReadLine();

                arena.Combater(decisao1, decisao2);
            }

            Console.WriteLine("Batalha encerrada!");
            Console.WriteLine("O vencedor é: {0}!", arena.GetVencedor().Nome);

            Console.ReadLine();
        }
    }
}
