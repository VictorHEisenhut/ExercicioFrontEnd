using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    public static class Dao
    {
        private static List<Pessoa> Pessoas { get; set; } = new();

        public static void Add(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
            
        }

        public static Pessoa GetById(int id)
        {
            return Pessoas.FirstOrDefault(p => p.Id == id);
        }

        public static int GetLenght()
        {
            return Pessoas.Count;
        }
    }
}
