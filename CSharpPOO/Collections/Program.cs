namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Categoria sorvete = new Categoria() { Descricao = "Sorvete", ID = 1};

            Produto produto = new Produto() { ID = 1, Preco = 25.90, Descricao = "Sorvete", Categoria = sorvete};

            Console.WriteLine(produto.ToString());

        }
    }
}