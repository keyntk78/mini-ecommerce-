using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniEcommerce.InventoryTickets;
using MiniEcommerce.Manufacturers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Configurations.Manufacturers
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.ToTable(MiniEcommerceConsts.DbTablePrefix + "Manufacturers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x=>x.Code) .HasMaxLength(50).IsUnicode(false).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(50).IsUnicode(false).IsRequired();
            builder.Property(x => x.CoverPicture).HasMaxLength(250);

        }
    }
}
