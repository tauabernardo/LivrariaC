namespace LivrariaAPI.Models
{
    public class LivroDigital : Livro
    {
        public double TamanhoArquivoMB { get; set; } 
        public string Formato { get; set; } = string.Empty; 
    }
}
