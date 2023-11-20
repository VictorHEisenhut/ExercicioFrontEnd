using CriandoBD.Dao;
using CriandoBD.Entidades;

namespace CriandoBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Contato ctt = new("giulia", "giulia@gmail.com", "(47)99843-6773");
            if (DaoContato.Salvar(ctt))
            {
                Console.WriteLine("Contato salvo");
            }*/

            var ctts = DaoContato.GetContatos();
            foreach (var item in ctts)
            {
                Console.WriteLine(item);
            }

            //Locais local = new("Timbó", "Quintino", "Botuverá", 532, "89120-000");
            //if (DaoLocais.Salvar(local))
            //{
            //    Console.WriteLine("Local salvo!");
            //}

            var loc = DaoLocais.GetLocais();
            foreach (var item in loc)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}