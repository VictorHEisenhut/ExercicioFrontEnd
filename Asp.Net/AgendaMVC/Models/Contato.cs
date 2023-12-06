using System.ComponentModel.DataAnnotations;

namespace AgendaMVC.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(45, ErrorMessage ="Tamanho máximo de 45 caracteres"), MinLength(3, ErrorMessage ="Tamanho mínimo de 3 caracteres")]
        public string Nome { get; set; }
        [Required]
        [MaxLength(45, ErrorMessage ="Tamanho máximo de 45 caracteres"), MinLength(3, ErrorMessage ="Tamanho mínimo de 3 caracteres")]
        public string Email { get; set; }
        [Required]
        [StringLength(14, ErrorMessage ="Tamanho máximo de 14 caracteres")]
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
