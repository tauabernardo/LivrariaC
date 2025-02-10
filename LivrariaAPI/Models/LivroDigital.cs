namespace LivrariaAPI.DTOs
{
    public class LivroDigitalDTO
    {
        public string Titulo { get; set; }= string.Empty;
        public string Autor { get; set; }= string.Empty;
        public string ISBN { get; set; }= string.Empty;
        public double TamanhoArquivoMB { get; set; }
        public string Formato { get; set; }= string.Empty;
    }
}
