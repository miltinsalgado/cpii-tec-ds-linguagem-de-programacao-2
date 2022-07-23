using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula05
{
    class Batalha
    {
        private Heroi Combatente1;
        private Heroi Combatente2;
        private Heroi Vencedor;

        public Batalha(Heroi h1, Heroi h2)
        {
            Combatente1 = h1;
            Combatente2 = h2;
        }

        public void Combater(string decisao1, string decisao2)
        {
            Console.Clear();

            if (decisao1 == "atacar" && decisao2 == "esquivar")
            {
                Console.WriteLine("{0} recebeu {1} de dano!", Combatente2.Nome, Combatente1.GetAtaque());
                Combatente2.TomarDano(Combatente1.GetAtaque());
                Console.Write("Atacar > Esquivar");
            }

            if (decisao2 == "atacar" && decisao1 == "esquivar")
            {
                Console.WriteLine("{0} recebeu {1} de dano!", Combatente1.Nome, Combatente2.GetAtaque());
                Combatente1.TomarDano(Combatente2.GetAtaque());
                Console.Write("Atacar > Esquivar");
            }

            if (decisao1 == "esquivar" && decisao2 == "defender")
            {
                Console.WriteLine("{0} recebeu {1} de dano!", Combatente2.Nome, Combatente1.GetVelocidade());
                Combatente2.TomarDano(Combatente1.GetVelocidade());
                Console.Write("Esquivar > Defender");
            }

            if (decisao2 == "esquivar" && decisao1 == "defender")
            {
                Console.WriteLine("{0} recebeu {1} de dano!", Combatente1.Nome, Combatente2.GetVelocidade());
                Combatente1.TomarDano(Combatente2.GetVelocidade());
                Console.Write("Esquivar > Defender");
            }

            if (decisao1 == "defender" && decisao2 == "atacar")
            {
                Console.WriteLine("{0} recebeu {1} de dano!", Combatente2.Nome, Combatente1.GetDefesa());
                Combatente2.TomarDano(Combatente1.GetDefesa());
                Console.Write("Defender > Atacar");

            }

            if (decisao2 == "defender" && decisao1 == "atacar")
            {
                Console.WriteLine("{0} recebeu {1} de dano!", Combatente1.Nome, Combatente2.GetDefesa());
                Combatente1.TomarDano(Combatente2.GetDefesa());
                Console.Write("Defender > Atacar");
            }

            // Para que a mensagem seja mostrada na tela com calma
            Thread.Sleep(3000);
        }

        public bool CombatentesEstaoVivos()
        {
            if (Combatente1.GetVida() <= 0)
            {
                Vencedor = Combatente2;
                return false;
            }

            if (Combatente2.GetVida() <= 0)
            {
                Vencedor = Combatente1;
                return false;
            }

            return true;

        }

        public Heroi GetVencedor()
        {
            return Vencedor;
        }
    }
}
