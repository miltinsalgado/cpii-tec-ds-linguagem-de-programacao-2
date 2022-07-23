using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_01_02_Teste_02
{
    // Nome: Milton Salgado Leandro - Turma: IN-210 - Professor: João Lagôas

    class Ponto
    {
        // Questão 01 - Letra a)
        // public decimal X {Escopo: de instância | Tipo: primitivo}
        // public decimal Y: {Escopo: de instância | Tipo: primitivo}
        // decimal x: {Escopo: local | Tipo: primitivo}
        // decimal y: {Escopo: local | Tipo: primitivo}
        // Ponto p1: {Escopo: local | Tipo: referencial}
        // Ponto p2: {Escopo: local | Tipo: referencial}
        // dist: {Escopo: local | Tipo: primitivo}

        public decimal X;
        public decimal Y;

        public Ponto(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public static decimal Distância(Ponto p1, Ponto p2)
        {
            double dist = Math.Sqrt(Math.Pow(Convert.ToDouble(p1.X - p2.X), 2) + Math.Pow(Convert.ToDouble(p1.Y - p2.Y), 2));
            return Convert.ToDecimal(dist);
        }
    }
}
