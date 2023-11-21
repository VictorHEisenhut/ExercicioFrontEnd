using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Categorias_Db.Entidades
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorUnit { get; set; }
        public int Estoque { get; set; }
        public Categoria Categoria { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double valorUnit, int estoque, Categoria categoria)
        {
            Nome = nome;
            ValorUnit = valorUnit;
            Estoque = estoque;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $"Nome: {Nome}\n" +
                $"Valor Unitário: {ValorUnit}\n" +
                $"Estoque: {Estoque}\n" +
                $"Categoria: {Categoria}\n";
        }
    }
}
