using ExercicioCollections;
using System.Net.Http.Headers;
using System.Security.AccessControl;

namespace ExercicioCollections
{
    internal class Program
    {
        public static List<Produtos> produtos = new();
        public static SortedList<Categoria, ProdutoEx3> sorted = new();
        public static SortedList<int, Categoria> sortedCategorias = new();

        static void Main(string[] args)
        {
            Console.WriteLine("[1] Para acessar exercício 1\n[2] Para acessar exercício 2 \n[3] Para acessar exercício 3");
            var opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    ExercicioPessoa();
                    break;
                case 2:
                    ExercicioProduto();
                    break;
                case 3:
                    ExercicioCategoria();
                    break;
            }
            
        }

        public static void ExercicioCategoria()
        {

            string condicao = "";

            while (condicao != "SIM")
            {
                Console.Clear();
                Console.WriteLine(
                    "---------MENU---------\n" +
                    "|[1] Criar Categoria |\n" +
                    "|[2] Criar Produto   |\n" +
                    "|[3] Ler Produtos    |\n" +
                    "|[4] Ler Categorias  |");

                try
                {
                    var opcao = Convert.ToInt32(Console.ReadLine());
                    
                    
                    Console.Clear();
                    switch (opcao)
                    {
                        case 1:
                            Categoria.CreateCategoria(sortedCategorias);
                            break;
                        case 2:
                            ProdutoEx3.CreateProduto(sorted, sortedCategorias);
                            break;
                        case 3:
                            ProdutoEx3.ReadProdutos(sorted);
                            break;
                        case 4:
                            Categoria.ReadCategorias(sortedCategorias);
                            break;

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Excessão capturada, pressione Enter para recomeçar");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine("Deseja encerrar o programa? (sim) (pressione qualquer tecla)");
                condicao = Console.ReadLine().ToUpper();
            }

        }

        public static void ExercicioProduto()
        {
            string condicao = "";

            while (condicao != "SIM")
            {
                Console.Clear();
                Console.WriteLine(
                    "------MENU------\n" +
                    "|[1] Adicionar  |\n" +
                    "|[2] Ler        |\n" +
                    "|[3] Remover    |");

                try
                {
                    var opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Produtos.AdicionarProdutos(produtos);
                            break;
                        case 2:
                            Produtos.LerProdutos(produtos);
                            break;
                        case 3:
                            Produtos.RemoveProdutos(produtos);
                            break;

                    }
                }
                catch (Exception)
                {
                    break;
                }
                Console.WriteLine("Deseja encerrar o programa? (sim) (pressione qualquer tecla)");
                condicao = Console.ReadLine().ToUpper();
            }
        }
        public static void ExercicioPessoa()
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = "Jamal",
                CPF = "123124124",
                Idade = 19,
                Endereco = "Rua botuverá"
            };

            SortedList<string, Pessoa> listaPessoas = new();

            listaPessoas.Add(pessoa.Nome, pessoa);

            foreach (var p in listaPessoas)
            {
                Console.WriteLine(p.Key);
                Console.WriteLine(p.Value);
            }
        }
        
        
    
    }
}


