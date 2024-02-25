using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain;

namespace Store.Persistence.Configurations.Entities
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId);

            for (int i = 1; i <= 10; i++)
            {
                builder.HasData(
                    new Product
                    {
                        Id = i,
                        Title = $"Product {i}",
                        Code = $"P00{i}",
                        Description = $"Description for Product {i}",
                        ImgUrl = $"URL for Product {i} Image",
                        CategoryId = i % 10 + 1, 
                        CreateDate = DateTime.Now,
                        IsDeleted = false
                    }
                );
            }
        }
    }
}
