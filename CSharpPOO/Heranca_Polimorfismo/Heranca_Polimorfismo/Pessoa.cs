using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public Pessoa()
        {
        
        }
        public Pessoa(int id, string nome)
        {
            ID = id;
            Nome = nome;
        }

        public string ToString()
        {
            return $"{ID} {Nome}";
        }
    }
}
