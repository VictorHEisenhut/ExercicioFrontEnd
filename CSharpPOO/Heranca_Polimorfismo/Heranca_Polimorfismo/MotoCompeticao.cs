using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class MotoCompeticao : Moto
    {
        public string Equipe { get; set; }

        public MotoCompeticao()
        {
            
        }
        public MotoCompeticao(int cilindrada, string equipe, string marca, int velocidadeMax, string modelo):base(cilindrada, marca, velocidadeMax, modelo)
        {
            Equipe = equipe;
        }

        public string ToString()
        {
            string pai = base.ToString();
            return $"{pai}\n Equipe: {Equipe}\n";
        }
    }
}
