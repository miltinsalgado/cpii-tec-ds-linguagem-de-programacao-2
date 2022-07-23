using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    class Heroi
    {
        // Atributos
        public string Nome;
        public bool EhHumano;
        private int Vida = 6;
        private int Ataque;
        private int Defesa = 1;
        private int Velocidade = 1;
        public static int Quantidade = 0;

        // Método Construtor
        public Heroi(string n, bool eH, int at, int def, int vel)
        {
            Nome = n;

            EhHumano = eH;

            if (SetAtaque(at) == false)
                Ataque = 1;

            SetDefesa(def); SetVelocidade(vel);

            Quantidade++;
        }

        // Métodos
        public string DescreverDados()
        {
            string descricao = "Nome: " + Nome + "\nEhHumano: " + EhHumano + "\nVida: " + Vida +  "\nAtaque: " + Ataque + "\nDefesa: " + Defesa + "\nVelocidade: " + Velocidade;
            return descricao;
        }

        public void TomarDano(int dano)
        {
            Vida -= dano;
        }

        //Métodos Setters e Getters
        public bool SetAtaque(int at)
        {
            if (at >= 0 || at <= 5)
            {
                Ataque = at;
                return true;
            }
            else
                return false;
        }

        public bool SetDefesa(int def)
        {
            if (def >= 0 || def <= 5)
            {
                Defesa = def;
                return true;
            }
            else
                return false;
        }

        public bool SetVelocidade(int vel)
        {
            if (vel >= 0 || vel <= 5)
            {
                Velocidade = vel;
                return true;
            }
            else
                return false;
        }

        public int GetVida()
        {
            return Vida;
        }

        public int GetAtaque()
        {
            return Ataque;
        }

        public int GetDefesa()
        {
            return Defesa;
        }

        public int GetVelocidade()
        {
            return Velocidade;
        }
    }
}
