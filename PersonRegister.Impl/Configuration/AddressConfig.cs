using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonRegister.Domain.Entities;

namespace PersonRegister.Impl.Configuration
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("ADDRESS");

            //builder.HasKey(p => p.ID);
            //builder.Property(p => p.Id).HasColumnName("ID").UseSqlServerIdentityColumn().IsRequired();
            builder.Property(p => p.Id).HasColumnName("ID").IsRequired();
            builder.Property(p => p.Number).HasColumnName("NUMBER").IsRequired();
            builder.Property(p => p.Name).HasColumnName("NAME").HasMaxLength(400);
            builder.Property(p => p.PostalCode).HasColumnName("POSTAL_CODE").HasMaxLength(40).IsRequired();
            builder.Property(p => p.Complement).HasColumnName("COMPLEMENT").IsRequired();
        }
    }
}
