namespace Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cliente cliente = new Cliente()
            //{
            //    ID = 1,
            //    Nome = "Jamal",
            //    CPF = "123456789"
            //};

            //Console.WriteLine(cliente.ToString());

            MotoCompeticao motoComp = new()
            {
                Marca = "BMW",
                Modelo = "1000RR",
                Equipe = "RedBull",
                Cilindrada = 1000,
                VelocidadeMax = 300
            };
            Console.WriteLine(motoComp.ToString());

            MotoPasseio motoPasseio = new()
            {
                Marca = "Honda",
                Modelo = "Biz",
                Cilindrada = 245,
                VelocidadeMax = 150,
                Bau = true
            };
            Console.WriteLine(motoPasseio.ToString());



        }
    }
}