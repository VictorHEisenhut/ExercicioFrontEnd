using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string descricao, double preco)
        {
            ID = id;
            Descricao = descricao;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"ID: {ID} | Descrição: {Descricao} | Preço: {Preco}";
        }
    }
}
