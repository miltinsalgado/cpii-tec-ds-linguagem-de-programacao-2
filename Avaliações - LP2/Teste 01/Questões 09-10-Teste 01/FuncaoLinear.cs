using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_09_10_Teste_01
{
    class FuncaoLinear
    {
        // Nome: Milton Salgado Leandro - Turma: IN-210 - Professor: João Lagôas

        private double A;
        public double B;

        public FuncaoLinear(double a, double b)
        {
            SetA(a);
            B = b;
        }

        // Criação do metódo setter "SetA" que verifica se "A" recebeu o valor 0 ou não, pois de acordo com o enunciado, a função linear NÃO pode ser constante.
        // Caso o valor de "a" seja 0, ele pede para o usuário entrar com um valor válido em um loop while, avaliando sempre se "a" é igual a 0, até que o valor de "a" seja diferente de 0.
        public void SetA(double a)
        {
            if (a != 0)
                A = a;
        }

        // Criação do metódo getter "GetA" que retorna o valor de "A", já que não podemos acessá-lo pelo operador "." por conta de seu nível de segurança "private".
        public double GetA()
        {
            return A;
        }

        public double Raiz()
        {
            if (B == 0)
                return B / A;
            else
                return -B / A;
        }

        public string Inclinacao()
        {
            if (A > 0)
                return "crescente";
            else
                return "descrescente";
        }

        public string Descrever()
        {
            if (B > 0)
                return "f(x)=" + A + "x+" + B;
            else if (B == 0)
                return "f(x)=" + A + "x";
            else
                return "f(x)=" + A + "x" + B;
        }
    }
}
