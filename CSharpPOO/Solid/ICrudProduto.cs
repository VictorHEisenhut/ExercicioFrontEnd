using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal interface ICrudProduto
    {
        public bool Salvar(Produto prod);
        public bool Alterar(Produto produto);
        public void ReadProdutos();
        public bool DeleteProduto(int id);


    }
}
