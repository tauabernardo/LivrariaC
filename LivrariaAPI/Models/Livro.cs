namespace LivrariaAPI.Models
{
    public abstract class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }= string.Empty;
        public string Autor { get; set; }= string.Empty;
        public string ISBN { get; set; }= string.Empty;
    }
}
