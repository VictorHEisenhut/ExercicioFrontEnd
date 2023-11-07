using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class MotoPasseio : Moto
    {
        public bool Bau { get; set; }

        public MotoPasseio()
        {
            
        }
        public MotoPasseio(int cilindrada, bool bau, string marca, string velocidadeMax, string modelo) :base(cilindrada, marca, velocidadeMax, modelo)
        {
            Bau = bau;
        }

        public string ToString()
        {
            string pai = base.ToString();
            return $"{pai}\n Baú: {Bau}\n";
        }
    }
}
