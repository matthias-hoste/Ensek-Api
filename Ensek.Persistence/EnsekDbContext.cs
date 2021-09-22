using Ensek.Domain.Models;
using Ensek.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Ensek.Persistence
{
    public class EnsekDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public EnsekDbContext(DbContextOptions<EnsekDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("ensek");
            modelBuilder.Seed();
        }
    }
}