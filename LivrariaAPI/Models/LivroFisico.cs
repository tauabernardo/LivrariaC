namespace LivrariaAPI.Models
{
    public class LivroFisico : Livro
    {
        public double Peso { get; set; }
        public string TipoCapa { get; set; } = string.Empty;
    }
}
