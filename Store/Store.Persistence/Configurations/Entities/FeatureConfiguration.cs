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
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            for (int i = 1; i <= 10; i++)
            {
                string value;
                switch (i % 3)
                {
                    case 0:
                        value = $"{i}";
                        break;
                    case 1:
                        value = (i % 2 == 0) ? "true" : "false";
                        break;
                    case 2:
                        value = $"Value {i}";
                        break;
                    default:
                        value = "Unknown";
                        break;
                }

                FeatureValueType type;
                switch (i % 3)
                {
                    case 0:
                        type = FeatureValueType.Number;
                        break;
                    case 1:
                        type = FeatureValueType.Boolean;
                        break;
                    case 2:
                        type = FeatureValueType.String;
                        break;
                    default:
                        type = FeatureValueType.String; 
                        break;
                }

                builder.HasData(
                    new Feature
                    {
                        Id = i,
                        Name = $"Feature {i}",
                        Value = value,
                        Type = type,
                        CreateDate = DateTime.Now,
                        IsDeleted = false
                    }
                );
            }
        }
    }
}
