using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonRegister.Domain.Entities;

namespace PersonRegister.Impl.Configuration
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("PERSON");

            //builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("ID").IsRequired();
            builder.Property(p => p.Name).HasColumnName("NAME").HasMaxLength(200);
            builder.Property(p => p.IndentificationDocument).HasColumnName("INDENTIFICATION_DOCUMENT").IsRequired();
            builder.Property(p => p.Gender).HasColumnName("GENDER").HasMaxLength(40).IsRequired();

            builder.HasOne(p => p.Addresses).WithMany(p => p.People).HasForeignKey(p => p.AddressId);
        }
    }
}
