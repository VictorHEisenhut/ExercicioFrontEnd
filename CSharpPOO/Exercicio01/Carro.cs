using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Carro
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor{ get; set; }

        public override string ToString()
        {
            return $"Placa: {this.Placa}\n" +
                $"Marca: {this.Marca}\n" +
                $"Modelo: {this.Modelo}\n" +
                $"Cor: {this.Cor}";
        }

    }
}
