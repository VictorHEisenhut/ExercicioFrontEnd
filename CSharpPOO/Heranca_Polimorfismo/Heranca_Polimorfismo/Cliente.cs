using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class Cliente : Pessoa
    {
        public string CPF { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(int id, string nome, string cpf) : base(id, nome)
        {
            CPF = cpf;
        }

        public string ToString()
        {
            string stringPai = base.ToString();
            return $"{stringPai} CPF: {CPF}";
        }

    }
}
