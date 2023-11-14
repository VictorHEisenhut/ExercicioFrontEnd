namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingleResponsability();
            liskov();
        }

        static void liskov()
        {
            GerenciaPersistenciaFatura gp1 = new(new PersistenciaEmArquivo());
            gp1.Executar(new Fatura());

            GerenciaPersistenciaFatura gp2 = new(new PersistenciaEmBD());
            gp2.Executar(new Fatura());
        
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