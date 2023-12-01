using System.ComponentModel.DataAnnotations;

namespace AgendaMVC.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $"Nome: {Nome}\n" +
                $"Email: {Email}\n" +
                $"Fone: {Fone}";
        }
    }
}
