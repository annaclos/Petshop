using System.Reflection.Metadata.Ecma335;

namespace Petshop.Model.Data
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
        public List<Animal>? Animais { get; set; }
        public IEnumerable<Servico>? Servico { get; set; }
    }
}
