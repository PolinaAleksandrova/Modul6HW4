using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data.EntityConfigurations;

public class CatalogTypeEntityTypeConfiguration
    : IEntityTypeConfiguration<CatalogType>
{
    public void Configure(EntityTypeBuilder<CatalogType> builder)
    {
        builder.ToTable("CatalogType");

        builder.HasKey(ci => ci.Id);

        builder.Property(ci => ci.Id)
            .UseHiLo("catalog_type_hilo")
            .IsRequired();

        builder.Property(cb => cb.Type)
            .IsRequired()
            .HasMaxLength(100);
        builder.HasData(
           new CatalogType { Id = 1, Type = "T-Shirt" },
           new CatalogType { Id = 2, Type = "Sheet" },
           new CatalogType { Id = 3, Type = "Mug" });
    }
}