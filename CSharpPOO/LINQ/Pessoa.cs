using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Aprovado { get; set; }


        public Pessoa()
        {

        }

        public Pessoa(int iD, string nome, string email, bool aprovado)
        {
            ID = iD;
            Nome = nome;
            Email = email;
            Aprovado = aprovado;
        }

        public override string ToString()
        {
            return $"{ID} - {Nome} - {Email}";
        }

    }
}
