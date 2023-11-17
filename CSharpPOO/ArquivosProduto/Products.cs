using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ArquivosProduto
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

        static string path = @"C:\Users\victor.eisenhut\Projects\CSharpPOO\Products.txt";

        public static void CreateProduct(List<Products> products)
        {
            CreateFile();
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
                Products product = new Products() { Codigo = codigo, Descricao = descricao, Estoque = estoque, ValorUnit = valor };
                products.Add(product);
                WriteInFile(products);

                Console.Clear();
                ReadProducts(products);

            }
            catch (FormatException)
            {
            }

        }

        public static void CreateFile()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                }
            }
        }
        public static void WriteInFile(List<Products> products)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (var produto in products)
                {
                    sw.WriteLine(produto);
                }

            }

        }
        public static void ReadInFile(List<Products> products)
        {
            products.Clear();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                int linha = 1;
                int codigo = 0;
                string descricao = "";
                int estoque = 0;
                double valor = 0;

                while ((s = sr.ReadLine()) != null)
                {
                    if (linha == 1)
                    {
                        int posI = s.IndexOf("|");
                        codigo = Convert.ToInt32(s.Substring(0, posI));

                        s = s.Remove(0, posI + 2);
                        posI = s.IndexOf("|");
                        descricao = s.Substring(0, posI);

                        s = s.Remove(0, posI + 2);
                        posI = s.IndexOf("|");
                        estoque = Convert.ToInt32(s.Substring(0, posI));

                        s = s.Remove(0, posI + 2);
                        posI = s.IndexOf("|");
                        valor = Convert.ToDouble(s.Substring(0, s.Length));

                        products.Add(new Products { Codigo = codigo, Descricao = descricao, Estoque = estoque, ValorUnit = valor });

                    }

                }
                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }
            }
        }


        public static void ReadProducts(List<Products> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }

        public static void UpdateProducts(List<Products> products)
        {
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

                        WriteInFile(products);
                    }
                }

            }
            catch (FormatException)
            {

            }
        }

        public static void DeleteProducts(List<Products> products)
        {
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
            WriteInFile(products);
        }   


        public override string ToString()
        {
            return $"{Codigo} | {Descricao} | {Estoque} | {ValorUnit}";
        }

    }
}

