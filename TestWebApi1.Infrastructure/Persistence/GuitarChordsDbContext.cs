using Microsoft.EntityFrameworkCore;
using TestWebApi1.Domain.Tabs;

namespace TestWebApi1.Infrastructure.Persistence
{
    public class GuitarChordsDbContext : DbContext
    {
        public GuitarChordsDbContext(DbContextOptions<GuitarChordsDbContext> options)
            : base(options)
        {}

        public DbSet<Tab> Tabs { get; set; }
    }
}
