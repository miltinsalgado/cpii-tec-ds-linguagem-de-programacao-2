using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_01_02_Teste_02
{
    class Círculo
    {
        // Nome: Milton Salgado Leandro - Turma: IN-210 - Professor: João Lagôas

        // Questão 01 - Letra b) Criação dos atributos ponto_central e raio.
        public Ponto ponto_central = new Ponto(0, 0);
        private decimal raio;

        // Questão 01 - Letra c) - Criação dos métodos de acesso e modificação
        // Sim, necessitamos aplicar o encapsulamento na variável raio, pois como o enunciado diz,
        // seu valor deve ser positivo (raio > 0).
        // Para isso, criei o método getter GetRaio e o método setter SetRaio para cumprir com o encapsulamento.

        public bool SetRaio(decimal r)
        {
            if (r > 0)
            {
                raio = r;
                return true;
            }
            else
                return false;
        }

        public decimal GetRaio()
        {
            return raio;
        }

        // Questão 01 - Letra d) - Criação do método construtor Circulo.
        public Círculo(Ponto p, decimal r)
        {
            ponto_central.X = p.X;
            ponto_central.Y = p.Y;
            SetRaio(r);
        }

        // Questão 01 - Letra e) - Criação dos métodos CalcularArea e CalcularPerimetro.
        public decimal CalcularÁrea(decimal r)
        {
            double area = Math.PI * Math.Pow(Convert.ToDouble(r), 2);
            return Convert.ToDecimal(area);
        }

        public decimal CalcularPerímetro(decimal r)
        {
            double perimetro = 2 * Math.PI * Convert.ToDouble(r);
            return Convert.ToDecimal(perimetro);
        }

        // Questão 01 - Letra f) - Criação do método Intercepta.
        public static bool Intercepta(Círculo cir1, Círculo cir2)
        {
            if (Ponto.Distância(cir1.ponto_central, cir2.ponto_central) <= cir1.raio + cir2.raio)
                return true;
            else
                return false;
        }

    }
}
