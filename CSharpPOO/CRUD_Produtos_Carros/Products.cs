using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Produtos_Carros
{
    internal class Products
    {
        private int codigo;
        private string descricao;
        private int estoque;
        private double valorUnit;


        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Código inválido");
                    throw new FormatException();
                }
                else
                {
                    codigo = value;
                }
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Descrição inválida");
                    throw new FormatException();

                }
                else
                {
                    descricao = value;
                }
            }
        }
        public int Estoque
        {
            get
            {
                return estoque;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Estoque inválido!");
                    throw new FormatException();

                }
                else
                {
                    estoque = value;
                }
            }
        }
        public double ValorUnit
        {
            get
            {
                return valorUnit;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cor inválida!");
                    throw new FormatException();

                }
                else
                {
                    valorUnit = value;
                }
            }
        }

        public Products()
        {

        }

        public Products(int codigo, string descricao, int estoque, double valorUnit)
        {
            Codigo = codigo;
            Descricao = descricao;
            Estoque = estoque;
            ValorUnit = valorUnit;
        }

        public static void CreateProduct(List<Products> products)
        {
            try
            {
                Console.WriteLine("Digite o código do produto");
                var codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a descrição do produto");
                var descricao = Console.ReadLine();

                Console.WriteLine("Digite o estoque do produto");
                var estoque = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor unitário do produto");
                var valor = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < products.Count; i++)
                {
                    if (codigo == products[i].Codigo)
                    {
                        Console.WriteLine("Código inválida");
                        throw new FormatException();
                    }
                }
                products.Add(new Products() {Codigo = codigo, Descricao = descricao, Estoque = estoque, ValorUnit = valor});

                Console.Clear();
                ReadProducts(products);

            }
            catch (FormatException)
            {
            }

        }

        public static void ReadProducts(List<Products> products)
        {
            foreach (var item in products)
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

        public static void UpdateProducts(List<Products> products)
        {
            //ReadPlacas(cars);
            Console.WriteLine("Digite o código do produto a ser editado:");
            var cod = Convert.ToInt32(Console.ReadLine());

            try
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Codigo.Equals(cod))
                    {

                        Console.WriteLine("Digite a descrição do produto");
                        var desc = Console.ReadLine();

                        Console.WriteLine("Digite o estoque do produto");
                        var estoque = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o valor do produto");
                        var valor = Convert.ToDouble(Console.ReadLine());

                        products[i] = new Products() { Codigo = products[i].Codigo, Descricao = desc, Estoque = estoque, ValorUnit = valor };
                    }
                }

            }
            catch (FormatException)
            {

            }
        }

        public static void DeleteProducts(List<Products> products)
        {
            //ReadPlacas(cars);
            Console.WriteLine("Digite o código do produto a ser excluído:");
            var cod = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Codigo.Equals(cod))
                {
                    products.Remove(products[i]);
                    Console.WriteLine("Produto removido!");
                }
            }
        }


        public override string ToString()
        {
            return $"\nInformações do produto:\n" +
                $"Codigo: {this.Codigo}\n" +
                $"Descrição: {this.Descricao}\n" +
                $"Estoque: {this.Estoque}\n" +
                $"Valor unitário: {this.ValorUnit}";
        }

    }
}






