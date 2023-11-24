using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoBD.Entidades
{
    internal class Locais
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }

        public Locais()
        {

        }

        public Locais(string cidade, string bairro, string rua, int numero, string cep)
        {
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            Cep = cep;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $"Cidade: {Cidade} \n" +
                $"Bairro: {Bairro} \n" +
                $"Rua: {Rua} \n" +
                $"Número: {Numero} \n" +
                $"CEP: {Cep}\n";
        }
    }
}
