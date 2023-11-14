using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class CrudProduto : ICrudProduto
    {
        List<Produto> produtos = new();
        public bool Salvar(Produto prod)
        {
            produtos.Add(prod);
            return true;
        }

        public bool Alterar(Produto produto)
        {
            Console.WriteLine("Alterado");
            return true;
        }

        public void ReadProdutos()
        {
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
        }

        public bool DeleteProduto(int id)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].ID == id)
                {
                    produtos.Remove(produtos[i]);
                    return true;
                }
            }
            return false;

        }

    }
}
