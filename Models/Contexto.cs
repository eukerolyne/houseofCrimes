using Microsoft.EntityFrameworkCore;

namespace houseofCrimes.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cadastro> Cadastro { get; set;}
        public DbSet<Filme>Filme { get; set; }
    }
}