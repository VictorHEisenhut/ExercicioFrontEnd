using System.ComponentModel.DataAnnotations;

namespace AulaEntity.Models.ViewModels.Local
{
    public class CreateLocalVM
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(40, ErrorMessage = "Nome deve ser menor que 40 caracteres", MinimumLength = 3)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Cep é obrigatório")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Estado é obrigatório")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Cidade é obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Endereço é obrigatório")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Bairro é obrigatório")]
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}
