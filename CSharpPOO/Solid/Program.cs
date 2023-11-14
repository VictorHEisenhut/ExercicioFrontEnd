namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleResponsability();
        }

        static void SingleResponsability()
        {
            CrudProduto crudProduto = new();
            Produto produto = new(1, "jujuba", 5);

            crudProduto.Salvar(produto);
            crudProduto.Salvar(new Produto(2, "jamal", 22));

            crudProduto.ReadProdutos();
        }
    }
}