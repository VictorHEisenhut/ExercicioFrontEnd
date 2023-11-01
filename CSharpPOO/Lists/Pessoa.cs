using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"ID: {this.ID}  Nome: {this.Nome}";
        }
    }
}
