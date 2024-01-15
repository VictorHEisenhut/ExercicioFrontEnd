namespace TestAPI.Entities
{
    public class Compromisso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Contato Contato { get; set; }
        public int ContatoId { get; set; }
        public Local Local { get; set; }
        public int LocalId { get; set; }
    }
}
