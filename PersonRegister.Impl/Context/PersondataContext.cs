using Microsoft.EntityFrameworkCore;
using PersonRegister.Impl.Configuration;

namespace PersonRegister.Impl.Context
{
    public class PersonDataContext : DbContext
    {
        public PersonDataContext(DbContextOptions<PersonDataContext> dbContext) : base(dbContext)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfig());
            modelBuilder.ApplyConfiguration(new PersonConfig());
        }

        public DbSet<PersonConfig> People { get; set; }
        public DbSet<AddressConfig> Addresses { get; set; }
    }
}
