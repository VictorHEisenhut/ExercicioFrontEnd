namespace CRUD_Produtos_Carros
{
    internal class Program
    {
        public static List<Car> cars = new List<Car>();
        static void Main(string[] args)
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
