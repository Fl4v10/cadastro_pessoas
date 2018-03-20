using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonRegister.Domain.Entities;

namespace PersonRegister.Impl.Configuration
{
    public class PersonConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("ADDRESS");

            builder.Property(p => p.Id).HasColumnName("ID").IsRequired();
            builder.Property(p => p.Number).HasColumnName("NUMBER").IsRequired();
            builder.Property(p => p.AddressName).HasColumnName("ADDRESSNAME").HasMaxLength(400);
            builder.Property(p => p.PostalCode).HasColumnName("POSTALCODE").HasMaxLength(40).IsRequired();
            builder.Property(p => p.Complement).HasColumnName("COMPLEMENT").IsRequired();
        }
    }
}
