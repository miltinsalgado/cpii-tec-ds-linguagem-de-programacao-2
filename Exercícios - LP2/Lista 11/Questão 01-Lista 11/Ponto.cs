using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_01_Lista_11
{
    class Ponto
    {
        public decimal X;
        public decimal Y;

        public Ponto(double x, double y)
        {
            X = Convert.ToDecimal(x);
            Y = Convert.ToDecimal(y);
        }

        public static double Distancia(Ponto p1, Ponto p2)
        {
            double dist = Math.Sqrt(Math.Pow(Convert.ToDouble(p1.X - p2.X), 2) + Math.Pow(Convert.ToDouble(p1.Y - p2.Y), 2));
            return dist;
        }

        public static List<double> Reta(Ponto p1, Ponto p2)
        {
            double A = Convert.ToDouble((p1.Y - p2.Y) / (p1.X - p2.X));
            double B = Convert.ToDouble(p1.Y) + (-1 * (A * Convert.ToDouble(p1.X)));
            List<double> Coeficientes = new List<double>();
            Coeficientes.Add(A);
            Coeficientes.Add(B);
            return Coeficientes;
        }

    }
}
