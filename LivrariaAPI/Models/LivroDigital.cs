namespace LivrariaAPI.Models
{
    public class LivroDigital : Livro
    {
        public double TamanhoArquivo { get; set; }
        public string Formato { get; set; } = string.Empty;
    }
}
