using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Retangulo
    {
        private int bases;
        private int altura;
        public int Base { 
            get
            {
                return bases;
            }
            set
            {
                if (value > 0)
                {
                    bases = value;
                }
                else
                {
                    Console.WriteLine("Base inválida!");
                }
            }
        }
        public int Altura { 
            get
            {
                return altura;
            }
            set
            {
                if (value > 0)
                {
                    altura = value;
                }
                else
                {
                    Console.WriteLine("Altura inválida!");
                }
            }
        }

        public Retangulo(int bases, int altura)
        {
            Base = bases;
            Altura = altura;
        }

        public int Area()
        {
            return this.Base * this.Altura;
        }

        public int Perimetro()
        {
            return (2 * this.Base ) + (2 * this.Altura);
        }


    }
}
