using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data.EntityConfigurations;

public class CatalogItemEntityTypeConfiguration
    : IEntityTypeConfiguration<CatalogItem>
{
    public void Configure(EntityTypeBuilder<CatalogItem> builder)
    {
        builder.ToTable("Catalog");

        builder.Property(ci => ci.Id)
            .UseHiLo("catalog_hilo")
            .IsRequired();

        builder.Property(ci => ci.Name)
            .IsRequired(true)
            .HasMaxLength(50);

        builder.Property(ci => ci.Price)
            .IsRequired(true);

        builder.Property(ci => ci.PictureFileName)
            .IsRequired(false);

        builder.HasOne(ci => ci.CatalogBrand)
            .WithMany()
            .HasForeignKey(ci => ci.CatalogBrandId);

        builder.HasOne(ci => ci.CatalogType)
            .WithMany()
            .HasForeignKey(ci => ci.CatalogTypeId);
        builder.HasData(
           new CatalogItem { Id = 1, CatalogBrandId = 1, CatalogTypeId = 3, Name = ".NET Bot Black Hoodie", PictureFileName = "1.png", Price = 19.50 },
           new CatalogItem { Id = 2, CatalogBrandId = 4, CatalogTypeId = 3, Name = ".NET Black&White Mug", PictureFileName = "2.png", Price = 8.50 },
           new CatalogItem { Id = 3, CatalogBrandId = 2, CatalogTypeId = 1, Name = "Prism White T-Shirt", PictureFileName = "3.png", Price = 12 },
           new CatalogItem { Id = 4, CatalogBrandId = 4, CatalogTypeId = 1, Name = ".NET Foundation T-Shirt", PictureFileName = "4.png", Price = 12 },
           new CatalogItem { Id = 5, CatalogBrandId = 3, CatalogTypeId = 2, Name = "Roslyn Red Sheet", PictureFileName = "5.png", Price = 8.50 },
           new CatalogItem { Id = 6, CatalogBrandId = 2, CatalogTypeId = 1, Name = ".NET Blue Hoodie", PictureFileName = "6.png", Price = 12 },
           new CatalogItem { Id = 7, CatalogBrandId = 1, CatalogTypeId = 1, Name = "Roslyn Red T-Shirt", PictureFileName = "7.png", Price = 12 },
           new CatalogItem { Id = 8, CatalogBrandId = 3, CatalogTypeId = 3, Name = "Kudu Purple hoodie", PictureFileName = "8.png", Price = 8.50 },
           new CatalogItem { Id = 9, CatalogBrandId = 3, CatalogTypeId = 3, Name = "Cup <T> White Mug", PictureFileName = "9.png", Price = 12 },
           new CatalogItem { Id = 10, CatalogBrandId = 2, CatalogTypeId = 2, Name = ".NET Foundation Sheet", PictureFileName = "10.png", Price = 12 },
           new CatalogItem { Id = 11, CatalogBrandId = 2, CatalogTypeId = 2, Name = "Cup<T> Sheet", PictureFileName = "11.png", Price = 8.50 },
           new CatalogItem { Id = 12, CatalogBrandId = 2, CatalogTypeId = 1, Name = "Prism White T-Shirt", PictureFileName = "11.png", Price = 12 });
    }
}