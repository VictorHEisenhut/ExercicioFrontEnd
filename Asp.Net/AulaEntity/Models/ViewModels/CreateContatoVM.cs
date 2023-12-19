using System.ComponentModel.DataAnnotations;

namespace AulaEntity.Models.ViewModels
{
    public class CreateContatoVM
    {
        [Required(ErrorMessage ="Nome é obrigatório")]
        [StringLength(20, ErrorMessage ="Nome deve ser menor que 20 caracteres", MinimumLength = 3)]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Fone é obrigatório")]
        public string Fone { get; set; }
    }
}
