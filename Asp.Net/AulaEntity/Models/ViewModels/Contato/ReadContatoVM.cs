using System.ComponentModel.DataAnnotations;

namespace AulaEntity.Models.ViewModels.Contato
{
    public class ReadContatoVM
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
    }
}
