using Microsoft.EntityFrameworkCore;

namespace houseofCrimes.Models
{
    public class DBContext
    {
        public DBContext(DbContextOptions<Contexto> options)
        {
            Options = options;
        }

        public DbContextOptions<Contexto> Options { get; }
    }
}