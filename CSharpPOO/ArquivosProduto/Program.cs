namespace ArquivosProduto
{
    internal class Program
    {
        public static List<Products> products = new();
        static void Main(string[] args)
        {
            string condicao = "";

            while (condicao != "SIM")
            {
                Console.Clear();
                Console.WriteLine(
                    "------MENU------\n" +
                    "|[1] Adicionar    |\n" +
                    "|[2] Ler produtos |\n" +
                    "|[3] Ler arquivo  |\n" +
                    "|[4] Editar       |\n" +
                    "|[5] Remover      |");

                try
                {
                    var opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Products.CreateProduct(products);
                            break;
                        case 2:
                            Products.ReadProducts(products);
                            break;
                        case 3:
                            Products.ReadInFile(products);
                            break;
                        case 4:
                            Products.UpdateProducts(products);
                            break;
                        case 5:
                            Products.DeleteProducts(products);
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
    }
}