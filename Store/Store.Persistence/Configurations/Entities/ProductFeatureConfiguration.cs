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
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(cf => new { cf.ProductId, cf.FeatureId });

            builder
                .HasOne(cf => cf.Product)
                .WithMany(c => c.ProductFeatures)
                .HasForeignKey(cf => cf.ProductId);

            builder
                .HasOne(cf => cf.Feature)
                .WithMany(f => f.ProductFeatures)
                .HasForeignKey(cf => cf.FeatureId);
        }

    }

}
