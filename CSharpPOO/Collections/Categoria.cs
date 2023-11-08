using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Categoria
    {
        public int ID { get; set; }
        public string Descricao { get; set; }

        public Categoria()
        {
        }
        public Categoria(int iD, string descricao)
        {
            ID = iD;
            Descricao = descricao;
        }

        public string ToString()
        {
            return $"{ID} - {Descricao}";
        }
    }
}
