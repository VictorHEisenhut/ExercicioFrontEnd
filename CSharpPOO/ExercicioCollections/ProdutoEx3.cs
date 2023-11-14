using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCollections
{
    internal class ProdutoEx3
    {
        public Categoria Categoria { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }

        public ProdutoEx3()
        {
            
        }

        public ProdutoEx3(Categoria categoria, string descricao, int estoque, double preco)
        {
            Categoria = categoria;
            Descricao = descricao;
            Estoque = estoque;
            Preco = preco;
        }

        public static void CreateProduto(SortedList<Categoria, ProdutoEx3> list, SortedList<int, Categoria> categorias)
        {
            Categoria.ReadCategorias(categorias);
            Console.WriteLine();
            Console.WriteLine("Digite o ID da categoria do produto");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a DESCRIÇÃO do produto:");
            var desc = Console.ReadLine();
            Console.WriteLine("Digite o ESTOQUE do produto:");
            var estoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o PREÇO do produto:");
            var preco = Convert.ToDouble(Console.ReadLine());

            Categoria cat = Categoria.GetCategoriaById(categorias, id);
            ProdutoEx3 produto = new ProdutoEx3()
            {
                Categoria = cat,
                Descricao = desc,
                Estoque = estoque,
                Preco = preco
            };
            list.Add(produto.Categoria, produto);
        }

        public static void ReadProdutos(SortedList<Categoria, ProdutoEx3> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }

        public override string ToString()
        {
            return $"Descrição: {Descricao} Estoque: {Estoque} Preço: {Preco}";
        }
    }
}
