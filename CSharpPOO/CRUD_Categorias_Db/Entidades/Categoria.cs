using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Categorias_Db.Entidades
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Categoria()
        {

        }

        public Categoria(string descricao)
        {
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $"Descrição: {Descricao}";
        }
    }
}
