using Acme.BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.Configurations
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.NameAr).HasMaxLength(BookStoreConsts.GenericTextMaxLength);
            builder.Property(x => x.NameEn).HasMaxLength(BookStoreConsts.GenericTextMaxLength);
            builder.Property(x => x.DescriptionAr).HasMaxLength(BookStoreConsts.GenericTextMaxLength);
            builder.Property(x => x.DescriptionEn).HasMaxLength(BookStoreConsts.DescriptionTextMaxLength);

            builder.HasOne( x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .IsRequired();
        }
    }
}
