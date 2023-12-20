using System.ComponentModel.DataAnnotations;

namespace AulaEntity.Models.ViewModels.Compromisso
{
    public class UpdateCompromissoVM
    {
        [Required(ErrorMessage = "Descrição é obrigatória")]
        [StringLength(120, ErrorMessage = "Descrição deve ser menor que 120 caracteres", MinimumLength = 3)]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Data é obrigatória")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "Contato é obrigatório")]
        public int ContatoId { get; set; }
        [Required(ErrorMessage = "Local é obrigatório")]
        public int LocalId { get; set; }
    }
}
