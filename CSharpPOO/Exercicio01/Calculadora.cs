using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Calculadora
    {
        public double Somar(double x, double y)
        {
            return x + y;
        }

        public double Subtrair(double x, double y)
        {
            return x - y;
        }

        public double Dividir(double x, double y)
        {
            return x / y;
        }

        public double Multiplicar(double x, in double y)
        {
            return x * y;
        }

    }
}
