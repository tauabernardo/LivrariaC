using Microsoft.EntityFrameworkCore;
using LivrariaAPI.Models;

namespace LivrariaAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Livro> Livros { get; set; }
    public DbSet<LivroFisico> LivrosFisicos { get; set; }
    public DbSet<LivroDigital> LivrosDigitais { get; set; }
}
