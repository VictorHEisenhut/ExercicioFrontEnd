using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto() { }
        public Moto(int cilindrada, string marca, int velocidadeMax, string modelo):base(marca, velocidadeMax, modelo)
        {
            Cilindrada = cilindrada;
        }

        public string ToString()
        {
            string pai = base.ToString();
            return $"{pai}\n Clindradas: {Cilindrada}";
        }
    }
}
