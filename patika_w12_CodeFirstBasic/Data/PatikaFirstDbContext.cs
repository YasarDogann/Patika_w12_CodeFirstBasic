using Microsoft.EntityFrameworkCore;
using patika_w12_CodeFirstBasic.Models;

namespace patika_w12_CodeFirstBasic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

    }
}
