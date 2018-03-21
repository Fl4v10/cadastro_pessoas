using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PersonRegister.Impl.Context
{
    class PersonDbContextFactory : IDesignTimeDbContextFactory<PersonDataContext>
    {
        public PersonDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonDataContext>();
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-P6NLD0E;Initial Catalog=PersonDb;Integrated Security=True;MultipleActiveResultSets=True");

            return new PersonDataContext(optionsBuilder.Options);
        }
    }
}
