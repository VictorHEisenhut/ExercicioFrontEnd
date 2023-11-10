using System.Net.Http.Headers;
using System.Security.AccessControl;

namespace ExercicioCollections
{
    internal class Program
    {
        public static List<Produtos> produtos = new();

        static void Main(string[] args)
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