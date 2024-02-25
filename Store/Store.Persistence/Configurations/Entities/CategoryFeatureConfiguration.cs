using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Store.Persistence.Configurations.Entities
{
    public class CategoryFeatureConfiguration : IEntityTypeConfiguration<CategoryFeature>
    {
        public void Configure(EntityTypeBuilder<CategoryFeature> builder)
        {
            builder.HasKey(cf => new { cf.CategoryId, cf.FeatureId });

            builder
                .HasOne(cf => cf.Category)
                .WithMany(c => c.CategoryFeatures)
                .HasForeignKey(cf => cf.CategoryId);

            builder
                .HasOne(cf => cf.Feature)
                .WithMany(f => f.CategoryFeatures)
                .HasForeignKey(cf => cf.FeatureId);

            for (int i = 1; i <= 10; i++)
            {
                builder.HasData(
                    new CategoryFeature
                    {
                        CategoryId = i,
                        FeatureId = i
                    }
                    );
            }
        }

    }

}
