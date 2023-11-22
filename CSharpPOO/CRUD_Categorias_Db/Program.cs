using CRUD_Categorias_Db.Dao;
using CRUD_Categorias_Db.Entidades;

namespace CriandoBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string condicao = "";
            while (condicao != "SIM")
            {
                Console.Clear();
                Console.WriteLine("[1] Criar categoria\n" +
                                  "[2] Listar categorias\n" +
                                  "[3] Atualizar categorias\n" +
                                  "[4] Deletar categoria\n" +
                                  "-------------------------\n" +
                                  "[5] Criar produto\n" +
                                  "[6] Listar produtos\n" +
                                  "[7] Atualizar produto\n" +
                                  "[8] Deletar produto\n" +
                                  "[9] Listar produtos por categoria");
                var opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CreateCategoria();
                        break;
                    case 2:
                        GetCategorias();
                        break;
                    case 3:
                        UpdateCategoria();
                        break;
                    case 4:
                        DeleteCategoria();
                        break;
                    case 5:
                        CreateProduto();
                        break;
                    case 6:
                        GetProdutos();
                        break;
                    case 7:
                        UpdateProduto();
                        break;
                    case 8:
                        DeleteProduto();
                        break;
                    case 9:
                        GetProdutosByCategoria();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Deseja encerrar o programa? (SIM)");
                condicao = Console.ReadLine();
            }

            Console.ReadKey();
        }

        static void CreateCategoria()
        {
            Categoria categoria = new Categoria();

            Console.WriteLine("Digite a descrição do produto:");
            categoria.Descricao = Console.ReadLine();

            if (DaoCategoria.Salvar(categoria))
            {
                Console.WriteLine("Categoria salva!");
            }
        }

        static void GetCategorias()
        {
            var categorias = DaoCategoria.GetCategorias();

            foreach (var categoria in categorias)
            {
                Console.WriteLine(categoria);
            }
        }

        static void UpdateCategoria()
        {
            var categorias = DaoCategoria.GetCategorias();

            Console.WriteLine("Digite o ID da categoria a ser atualizada:");
            var id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < categorias.Count; i++)
            {
                if (id == categorias[i].Id)
                {
                    Console.Clear();
                    Console.WriteLine(categorias[i]);
                    Console.WriteLine("\nDigite a nova descrição:");
                    var newDesc = Console.ReadLine();
                    DaoCategoria.Update(categorias[i], new Categoria(newDesc));
                    break;
                }
            }
        }

        static void DeleteCategoria()
        {

            Console.WriteLine("Digite o ID da categoria que deseja excluir:");
            var id = Convert.ToInt32(Console.ReadLine());
            var categoria = DaoCategoria.GetCategoriaByID(id);

            if (id == categoria.Id)
            {
                Console.Clear();
                Console.WriteLine(categoria);
                Console.WriteLine("Tem certeza que seja excluir permanentemente esta categoria?(SIM)");
                var r = Console.ReadLine();
                if (r.ToUpper() == "SIM")
                {
                    DaoCategoria.Delete(categoria);
                    Console.WriteLine("Categoria deletada.");
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////

        static void CreateProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine("Digite o nome do produto:");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto:");
            produto.ValorUnit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a estoque do produto:");
            produto.Estoque = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ID da categoria do produto:");
            var id = Convert.ToInt32(Console.ReadLine());
            var categoria = DaoCategoria.GetCategoriaByID(id);
            produto.Categoria = categoria;

            if (DaoProduto.Salvar(produto))
            {
                Console.WriteLine("Produto salvo!");
            }
        }

        static void GetProdutos()
        {
            var produtos = DaoProduto.GetProdutos();

            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        static void UpdateProduto()
        {

            Console.WriteLine("Digite o ID do produto a ser atualizado:");
            var id = Convert.ToInt32(Console.ReadLine());
            var produto = DaoProduto.GetProdutoByID(id);

            if (id == produto.Id)
            {
                Console.Clear();
                Console.WriteLine(produto);
                Console.WriteLine("\nDigite o novo nome:");
                var newName = Console.ReadLine();
                Console.WriteLine("Digite o novo valor:");
                var newValue = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o novo estoque:");
                var newEstoque = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o novo ID de categoria:");
                var newCatID = Convert.ToInt32(Console.ReadLine());
                DaoProduto.Update(produto, new Produto(newName, newValue, newEstoque, DaoCategoria.GetCategoriaByID(newCatID)));
            }
        }

        static void DeleteProduto()
        {

            Console.WriteLine("Digite o ID da categoria que deseja excluir:");
            var id = Convert.ToInt32(Console.ReadLine());
            var produto = DaoProduto.GetProdutoByID(id);


                if (id == produto.Id)
                {
                    Console.Clear();
                    Console.WriteLine(produto);
                    Console.WriteLine("Tem certeza que seja excluir permanentemente esta categoria?(SIM)");
                    var r = Console.ReadLine();
                    if (r.ToUpper() == "SIM")
                    {
                        DaoProduto.Delete(produto);
                        Console.WriteLine("Produto deletada.");
                    }
                }
        }

        static void GetProdutosByCategoria()
        {
            GetCategorias();

            Console.WriteLine("\nDigite o id da categoria:");
            var id = Convert.ToInt32(Console.ReadLine());

            var produtos = DaoProduto.GetProdutoByCategoria(id);

            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }
    }
}