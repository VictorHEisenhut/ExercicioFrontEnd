using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Calculadora
    {
        private double x;
        private double y;

        public double X { 
            get
            {
                return x;
            }
            set
            {
                if (value > 0)
                {
                    x = value;
                    
                }
                else
                {
                    Console.WriteLine($"Número deve ser maior que 0");
                }
            }
        }
        public double Y {
            get
            {
                return y;
            }
            set
            {
                if (value > 0)
                {
                    y = value;
                }
                else
                {
                    Console.WriteLine("Número deve ser maior que 0");
                }
            }
        }

        public Calculadora(double x, double y)
        {
            X= x;
            Y= y;
            Somar();
            Subtrair();
            Dividir();
            Multiplicar();
        }

        public double Somar()
        {
            var soma = this.x + this.y;
            Console.WriteLine(soma);
            return soma;
        
        }

        public double Subtrair()
        {
            var sub = this.x - this.y;
            Console.WriteLine(sub);
            return sub;
        }

        public double Dividir()
        {
            var divisao = this.x / this.y;
            Console.WriteLine(divisao);
            return divisao;
        }

        public double Multiplicar()
        {
            var mult = this.x * this.y;
            Console.WriteLine(mult);
            return mult;
        }

    }
}
