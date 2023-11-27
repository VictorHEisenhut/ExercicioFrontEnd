using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class DaoPessoa
    {
        private Dictionary<int, Pessoa> dic = new Dictionary<int, Pessoa>();

        public bool AddPessoa()
        {
            Console.WriteLine("Digite o id:");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o email:");
            var email = Console.ReadLine();
         
            dic.Add(id, new Pessoa { ID = id, Nome = nome, Email = email, Aprovado = true });
            return true;
        }

        public Pessoa GetByID(int id)
        {
            var query = from user in dic
                        where user.Value.ID == id && user.Value.Aprovado == true
                        select user.Value;

            foreach (var user in query)
            {
                return user;
            }
            return null;
        }
    }
}
