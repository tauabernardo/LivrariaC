namespace LivrariaAPI.DTOs
{
    public class LivroFisicoDTO
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public double Peso { get; set; }
        public string TipoCapa { get; set; } = string.Empty;
    }
}
