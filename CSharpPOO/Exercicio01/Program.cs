using System.Security.AccessControl;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual exercício deseja acessar?");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Exercicio01();
                    break;

                case "2":
                    Exercicio02();
                    break;

                case "3":
                    Exercicio03();
                    break;

                case "4":
                    Exercicio04();
                    break;

            }
            
            

        }


        static void Exercicio01()
        {
            Console.WriteLine("Digite a placa do carro");
            var placa = Console.ReadLine();

            Console.WriteLine("Digite a marca do carro");
            var marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro");
            var modelo = Console.ReadLine();

            Console.WriteLine("Digite a cor do carro");
            var cor = Console.ReadLine();

            Carro car = new(placa, marca, modelo, cor);

            //Carro car = new()
            //{
            //    Placa = placa,
            //    Marca = marca,
            //    Modelo = modelo,
            //    Cor = cor
            //};

            Console.WriteLine(car);
        }

        static void Exercicio02()
        {
            Console.WriteLine("Escreva o 1º número:");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva o 2º número:");
            var y = Convert.ToDouble(Console.ReadLine());

            Calculadora calc = new(x, y);
        }
        
        static void Exercicio03()
        {
            
            Console.WriteLine("Digite a base do retângulo:");
            var bases = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo");
            var altura = Convert.ToInt32(Console.ReadLine());
            Retangulo retangulo = new(bases, altura);

            Console.WriteLine($"Área: {retangulo.Area()}");
            Console.WriteLine($"Perímetro: {retangulo.Perimetro()}");


        }

        static void Exercicio04()
        {
            Console.WriteLine("Digite o código do produto:");
            var codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a descrição do produto:");
            var descricao = Console.ReadLine();
            Console.WriteLine("Digite o estoque do produto:");
            var estoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto:");
            var valorUnit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite 1 para aplicar DESCONTO ou 2 para ACRÉSCIMO");
            var opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem:");
            var porcentagem= Convert.ToDouble(Console.ReadLine());

            Produtos produto = new(codigo, descricao, estoque, valorUnit, porcentagem);
            
            Console.Clear();
            if (opcao == 1)
            {
                Console.WriteLine(produto);
                Console.WriteLine($"Valor após desconto: {produto.Desconto(produto.Porcentagem)}");
            }
            else
            {
                Console.WriteLine(produto);
                Console.WriteLine($"Valor após acréscimo: {produto.Acrescimo(produto.Porcentagem)}");

            }


        }
    }
}