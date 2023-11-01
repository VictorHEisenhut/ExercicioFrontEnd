namespace CRUD_Produtos_Carros
{
    internal class Car
    {
        private string placa;
        private string marca;
        private string modelo;
        private string cor;


        public string Placa
        {
            get
            {
                return placa;
            }
            set
            {
                if (value.Length != 7)
                {
                    Console.WriteLine("Placa inválida");
                    throw new FormatException();
                }
                else
                {
                    placa = value;
                }
            }
        }
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Marca inválida");
                    throw new FormatException();

                }
                else
                {
                    marca = value;
                }
            }
        }
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Modelo inválido!");
                    throw new FormatException();

                }
                else
                {
                    modelo = value;
                }
            }
        }
        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Cor inválida!");
                    throw new FormatException();

                }
                else
                {
                    cor = value;
                }
            }
        }

        public Car()
        {

        }

        public Car(string placa, string marca, string modelo, string cor)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
        }


        public static void CreateCar(List<Car> cars)
        {
            try
            {
                Console.WriteLine("Digite a placa do carro");
                var placa = Console.ReadLine();

                Console.WriteLine("Digite a marca do carro");
                var marca = Console.ReadLine();

                Console.WriteLine("Digite o modelo do carro");
                var modelo = Console.ReadLine();

                Console.WriteLine("Digite a cor do carro");
                var cor = Console.ReadLine();

                for (int i = 0; i < cars.Count; i++)
                {
                    if (placa == cars[i].Placa)
                    {
                        Console.WriteLine("Placa inválida");
                        throw new FormatException();
                    }
                }
                cars.Add(new Car() { Placa = placa, Marca = marca, Modelo = modelo, Cor = cor });

                Console.Clear();
                ReadCars(cars);

            }
            catch (FormatException)
            {
            }

        }

        public static void ReadCars(List<Car> cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        static void ReadPlacas(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"Placa {i}: {cars[i].Placa}");
            }

        }

        public static void UpdateCars(List<Car> cars)
        {
            ReadPlacas(cars);
            Console.WriteLine("Digite a placa do carro a ser editado:");
            var placa = Console.ReadLine();

            try
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Placa.Equals(placa))
                    {
                        Console.WriteLine("Digite a placa do carro");
                        var placaNova = Console.ReadLine();

                        Console.WriteLine("Digite a marca do carro");
                        var marca = Console.ReadLine();

                        Console.WriteLine("Digite o modelo do carro");
                        var modelo = Console.ReadLine();

                        Console.WriteLine("Digite a cor do carro");
                        var cor = Console.ReadLine();

                        cars[i] = new Car() { Placa = placaNova, Marca = marca, Modelo = modelo, Cor = cor };
                    }
                }

            }
            catch (FormatException)
            {

            }
        }

        public static void DeleteCars(List<Car> cars)
        {
            ReadPlacas(cars);
            Console.WriteLine("Digite a placa do carro a ser excluído:");
            var placa = Console.ReadLine();

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Placa.Equals(placa))
                {
                    cars.Remove(cars[i]);
                    Console.WriteLine("Carro removido!");
                }
            }
        }


        public override string ToString()
        {
            return $"\nInformações do carro:\n" +
                $"Placa: {this.Placa}\n" +
                $"Marca: {this.Marca}\n" +
                $"Modelo: {this.Modelo}\n" +
                $"Cor: {this.Cor}";
        }

    }
}


