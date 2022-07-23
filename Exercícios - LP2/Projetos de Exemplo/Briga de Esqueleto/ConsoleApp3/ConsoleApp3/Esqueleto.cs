using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Esqueleto
    {
        // Atributos de um Esqueleto
        public string nome;
        public int vida;
        public int ataque;
        public bool estaViva;

        // Construtor do Esqueleto. Note que estaViva sempre é inicilizado como true. Eu não preciso dessa informação sendo atribuída pelo parâmetro.
        public Esqueleto(string n, int v, int at)
        {
            nome = n;
            vida = v;
            ataque = at;
            estaViva = true;
        }

        // Quando esse método é chamado, o Esqueleto toma dano e tem sua vida reduzida.
        // Além disso, se a vida dela for reduzida a zero ou menos, então vamos atualizar o atributo estaViva para false
        public void TomarDano(int dano)
        {
            vida = vida - dano;

            if (vida <= 0)
                estaViva = false;
        }
    }
}
