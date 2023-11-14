using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCollections
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }



        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {CPF}\n Idade: {Idade}\n Endereço: {Endereco}";
        }
    }
}
