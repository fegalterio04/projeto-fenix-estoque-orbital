namespace ProjetoFênix.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public string Categoria { get; set; } = string.Empty;
    }
}