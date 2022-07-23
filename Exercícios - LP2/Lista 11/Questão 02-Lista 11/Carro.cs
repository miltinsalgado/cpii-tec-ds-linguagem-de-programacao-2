using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_02_Lista_11
{
    class Carro
    {
        public double S = 0;
        public double V = 0;
        private double A = 0;
        public string Piloto = "";

        // No conceito de Movimento Uniformemente Variado, a aceleração é constante e não nula.
        // Para evitar

        public Carro(double s, double v, double a, string p)
        {
            S = s;
            V = v;
            SetAceleração(a);
            Piloto = p;
        }

        public bool SetAceleração(double a)
        {
            if (a != 0)
            {
                A = a;
                return true;
            }
            else
            {
                A = 1;
                return false;
            }       
        }

        public double GetAceleração()
        {
            return A;
        }

        public void Mover(double t)
        {
            S += V + t + ((A + t + t) / 2);
            V += A * t;
        }
    }
}
