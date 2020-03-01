using Microsoft.EntityFrameworkCore;

namespace lista_livros_razor.Models
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options) : base(options)
        {       
        }

        public DbSet<Livro> Livros { get; set; }
    }
}