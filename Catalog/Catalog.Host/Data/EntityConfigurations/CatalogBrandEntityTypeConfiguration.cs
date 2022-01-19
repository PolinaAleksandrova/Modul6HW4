using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data.EntityConfigurations;

public class CatalogBrandEntityTypeConfiguration
    : IEntityTypeConfiguration<CatalogBrand>
{
    public void Configure(EntityTypeBuilder<CatalogBrand> builder)
    {
        builder.ToTable("CatalogBrand");

        builder.HasKey(ci => ci.Id);

        builder.Property(ci => ci.Id)
            .UseHiLo("catalog_brand_hilo")
            .IsRequired();

        builder.Property(cb => cb.Brand)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasData(
            new CatalogBrand { Id = 1, Brand = "brand1" },
            new CatalogBrand { Id = 2, Brand = "brand2" },
            new CatalogBrand { Id = 3, Brand = "brand3" },
            new CatalogBrand { Id = 4, Brand = "brand4" });
    }
}