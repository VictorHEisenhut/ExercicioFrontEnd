using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCollections
{
    internal class Produtos
    {

        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }

        public Produtos()
        {
        }

        public Produtos(string descricao, int estoque, double preco)
        {
            Descricao = descricao;
            Estoque = estoque;
            Preco = preco;
        }

        public static void AdicionarProdutos(List<Produtos> produtos)
        {
            Produtos produto = new();
            Console.WriteLine("Digite a descrição do produto");
            produto.Descricao = Console.ReadLine();
            Console.WriteLine("Digite o estoque do produto");
            produto.Estoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto");
            produto.Preco = Convert.ToDouble(Console.ReadLine());

            if (produtos.Count != 0)
            {
                for (int i = 0; i < produtos.Count; i++)
                {
                    if (!produtos[i].Descricao.Equals(produto.Descricao))
                    {
                        produtos.Add(produto);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Produto já existente");
                        break;
                    }
                }

            }
            else
            {
                produtos.Add(produto);
            }

        }

        public static void LerProdutos(List<Produtos> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
        }

        public static void RemoveProdutos(List<Produtos> produtos)
        {
            LerProdutos(produtos);
            Console.WriteLine("Digite a descrição do produto");
            var desc = Console.ReadLine();

            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].Descricao.Equals(desc))
                {
                    produtos.Remove(produtos[i]);
                    Console.WriteLine("Produto removido!");
                    break;
                }
                else { Console.WriteLine("Produto não encontrado!"); break; }
            }
        }

        public override string ToString()
        {
            return $"Descrição: {Descricao} Estoque: {Estoque} Preco: {Preco}";
        }
    }
}
