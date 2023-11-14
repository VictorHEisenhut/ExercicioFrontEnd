using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Produto
    {

        public int ID { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }

        public string ToString()
        {
            return $"{ID} {Descricao}, {Preco}, {Categoria.ToString()}";
        }

    }
}
