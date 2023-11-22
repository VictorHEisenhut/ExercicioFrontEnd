using CRUD_Categorias_Db.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Categorias_Db.Interfaces
{
    internal interface IDaoCrud<T>
    {
        public bool Salvar(T t);
        public List<T> GetItens();
        public T GetItemByID(int id);
        public bool Update(T t);
        public bool Delete(T t);
        

    }
}
