using AulaEntity.Models.ViewModels.Contato;
using AulaEntity.Models.ViewModels.Local;

namespace AulaEntity.Models.ViewModels.Compromisso
{
    public class ReadCompromissoVM
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        //public AulaEntity.Models.Contato Contato { get; set; }
        //public AulaEntity.Models.Local Local { get; set; }
        public ReadContatoVM Contato { get; set; }
        public ReadLocalVM Local { get; set; }
    }
}
