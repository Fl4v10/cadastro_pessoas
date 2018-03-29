using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PersonRegister.Impl.Context;
using System;
namespace PersonRegister.Test.Extensions
{
    public static class TestExtensions
    {
        public static DbContextOptions<PersonDataContext> GetDBOptions(this PersonTest clientTest)
        {
            DbContextOptionsBuilder<PersonDataContext> optionsBuilder = new DbContextOptionsBuilder<PersonDataContext>();
            optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString()).ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning));
            return optionsBuilder.Options;
        }
    }
}
