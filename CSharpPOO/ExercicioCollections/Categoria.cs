using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCollections
{
    internal class Categoria: IComparable<Categoria>
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Categoria()
        {
            
        }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public static void CreateCategoria(SortedList<int, Categoria> list)
        {
            Console.WriteLine("Digite o ID da categoria:");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o NOME da categoria");
            var nome = Console.ReadLine();

            Categoria categoria = new Categoria()
            {
                Id = id,
                Nome = nome
            };

            list.Add(categoria.Id, categoria);

        }

        public static void ReadCategorias(SortedList<int, Categoria> list)
        {
            foreach (var categoria in list)
            {
                Console.WriteLine(categoria);
            }
        }

        public static Categoria GetCategoriaById(SortedList<int, Categoria> list, int id)
        {
            try
            {
                for (int i = 1; i <= list.Count; i++)
                {
                    if (list[i].Id == id)
                    {
                        return list[i];
                    }
                }
                Console.WriteLine("Categoria não encontrada");

            }
            catch(Exception ex) { 
               Console.WriteLine(ex.Message);
             }
                       
            return null;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Nome: {Nome}";
        }

        //Falta implementação do IComparable

        public int CompareTo(Categoria? other)
        {
            throw new NotImplementedException();
        }
    }
}
