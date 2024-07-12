namespace Petshop.Model.Data
{
    public class Servico
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set;}
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
