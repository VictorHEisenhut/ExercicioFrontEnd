using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Retangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

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
