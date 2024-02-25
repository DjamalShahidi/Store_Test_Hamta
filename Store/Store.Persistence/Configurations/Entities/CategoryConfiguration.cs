using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Store.Persistence.Configurations.Entities
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            for (int i = 1; i <= 10; i++)
            {
                builder.HasData(
                    new Category
                    {
                        Id = i,
                        Title = $"Category {i}",
                        CreateDate = DateTime.Now,
                        IsDeleted = false
                    }
                );
            }
        }

        
    }
}
