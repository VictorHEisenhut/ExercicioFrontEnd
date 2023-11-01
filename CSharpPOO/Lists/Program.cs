namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new();

            nomes.Add("Jamal");
            nomes.Add("Giulia");
            nomes.Add("Trolls");

            foreach (var item in nomes)
            {
                var aux = item.ToUpper();
                Console.WriteLine(aux);
            }
            Console.WriteLine("///////////////////////////////////////////");

            List<Pessoa> pessoas = new();
            pessoas.Add(new Pessoa() { ID = 1, Nome = "Jamal" });
            pessoas.Add(new Pessoa() { ID = 2, Nome = "Xamuel" });
            pessoas.Add(new Pessoa() { ID = 3, Nome = "Kleber" });

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }

            Console.ReadKey();
        }
    }
}