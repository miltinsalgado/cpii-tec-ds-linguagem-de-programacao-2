using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iremos instanciar dois objetos da classe Esqueleto.
            // objeto a: Nome="A", Vida=10, Ataque=3
            Esqueleto a = new Esqueleto("A", 10, 3);
            // objeto b: Nome="B", Vida=10, Ataque=3
            Esqueleto b = new Esqueleto("B", 10, 3);

            // Iremos instanciar um objeto da classe Random
            // Note que esta classe existe no próprio .NET, a gente não precisa criá-la!
            // Mas já que a gente está aprendendo a os conceitos da P.O.O., naturalmente saberemos utilizá-la

            // Iremos instanciar um objeto da classe Random
            // Note que toda a nomenclatura esta de acordo com o que estamos estudando
            // Declarei uma variável chamada saco do tipo Random e depois instanciei um objeto (new) chamando o contrutor Random() que não recebe parâmetro
            Random saco = new Random();

            // Esse While vai ser sempre avaliado como true "ENQUANTO A ESTÁ VIVA e B ESTÁ VIVA"
            // Perceba que se você ler o código em inglês/português, faz total sentido: while a está viva e b está viva
            while (a.estaViva && b.estaViva)
            {
                Console.WriteLine("Esqueletos se atacando");

                // Um número aleatório é tirado do saco: esse número pode ser 0 ou 1, apenas. O 2 não participa do sorteio.
                // Para mais informações, passe o mouse no método Next e leia a sua descrição.
                int numero = saco.Next(0, 2);

                // Se o número sorteado foi 0, então o esqueleto A vai tomar o dano e o esquelto B vai atacar
                if (numero == 0)
                {
                    Console.WriteLine("Caveira {0} está atacando!", b.nome);
                    a.TomarDano(b.ataque);
                }

                // Se o número sorteado foi 1, então o esqueleto B vai tomar o dano e o esquelto A vai atacar
                if (numero == 1)
                {
                    Console.WriteLine("Caveira {0} está atacando!", a.nome);
                    b.TomarDano(a.ataque);
                }

                // Este comando (apesar de não fazer muito sentido agora para vocês) simplesmente faz com que o seu programa espere 5 segundos antes de continuar.
                // Essa notação será esclarecida em breve, não se preocupe.
                Thread.Sleep(5000);

                // Se o esqueleto A não está mais vivo (note o operador de negação na frente) então eu posso dizer quem é o vencedor.
                if (!a.estaViva)
                {
                    Console.WriteLine("O vencendor é " + b.nome);
                }

                // Se o esqueleto B não está mais vivo (note o operador de negação na frente) então eu posso dizer quem é o vencedor.
                if (!b.estaViva)
                {
                    Console.WriteLine("O vencendor é " + a.nome);
                }
            }

            //Se eu saí do laço, então um dos esqueletos "morreu"/não está mais vivo. Posso mandar uma mensagem de encerramento.
            Console.WriteLine("Batalha terminou");

            Console.ReadLine();
        }
    }
}
