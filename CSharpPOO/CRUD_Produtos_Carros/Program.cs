namespace CRUD_Produtos_Carros
{
    internal class Program
    {
        public static List<Car> cars = new List<Car>();
        public static List<Products> products = new List<Products>();
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Para acessar exercício 01\n[2] Para acessar exercício 02");
            var opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    ExercicioCarro();
                    break;
                case 2:
                    ExercicioProdutos();
                    break;
                default:
                    break;
            }
        }
        static void ExercicioProdutos()
        {
            string condicao = "";

            while (condicao != "SIM")
            {
                Console.Clear();
                Console.WriteLine(
                    "------MENU------\n" +
                    "|[1] Adicionar    |\n" +
                    "|[2] Ler produtos |\n" +
                    "|[3] Editar       |\n" +
                    "|[4] Remover      |");

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
                            Products.UpdateProducts(products);
                            break;
                        case 4:
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
        static void ExercicioCarro()
        {
            string condicao = "";

            while (condicao != "SIM")
            {
                Console.Clear();
                Console.WriteLine(
                    "------MENU------\n" +
                    "|[1] Adicionar  |\n" +
                    "|[2] Ler carros |\n" +
                    "|[3] Editar     |\n" +
                    "|[4] Remover    |");

                try
                {
                    var opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Car.CreateCar(cars);
                            break;
                        case 2:
                            Car.ReadCars(cars);
                            break;
                        case 3:
                            Car.UpdateCars(cars);
                            break;
                        case 4:
                            Car.DeleteCars(cars);
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
