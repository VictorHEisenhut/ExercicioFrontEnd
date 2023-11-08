using System.Net.Http.Headers;
using System.Security.AccessControl;

namespace ExercicioCollections
{
    internal class Program
    {
        public static List<Produtos> produtos = new();

        static void Main(string[] args)
        {

            string condicao = "SIM";
            while (condicao == "SIM")
            {
                

                Produtos.AdicionarProdutos(produtos);
                Produtos.LerProdutos(produtos);

                Console.WriteLine("Digite SIM para continuar a execução");
                condicao = Console.ReadLine().ToUpper();
            }
            //ExercicioPessoa();

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