﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Persistence;

#nullable disable

namespace Store.Persistence.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Store.Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("Store.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6686),
                            IsDeleted = false,
                            Title = "Category 1"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6753),
                            IsDeleted = false,
                            Title = "Category 2"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6764),
                            IsDeleted = false,
                            Title = "Category 3"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6772),
                            IsDeleted = false,
                            Title = "Category 4"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6781),
                            IsDeleted = false,
                            Title = "Category 5"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6792),
                            IsDeleted = false,
                            Title = "Category 6"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6798),
                            IsDeleted = false,
                            Title = "Category 7"
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6804),
                            IsDeleted = false,
                            Title = "Category 8"
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6810),
                            IsDeleted = false,
                            Title = "Category 9"
                        },
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 687, DateTimeKind.Local).AddTicks(6818),
                            IsDeleted = false,
                            Title = "Category 10"
                        });
                });

            modelBuilder.Entity("Store.Domain.CategoryFeature", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("CategoryFeatures");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            FeatureId = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            FeatureId = 2
                        },
                        new
                        {
                            CategoryId = 3,
                            FeatureId = 3
                        },
                        new
                        {
                            CategoryId = 4,
                            FeatureId = 4
                        },
                        new
                        {
                            CategoryId = 5,
                            FeatureId = 5
                        },
                        new
                        {
                            CategoryId = 6,
                            FeatureId = 6
                        },
                        new
                        {
                            CategoryId = 7,
                            FeatureId = 7
                        },
                        new
                        {
                            CategoryId = 8,
                            FeatureId = 8
                        },
                        new
                        {
                            CategoryId = 9,
                            FeatureId = 9
                        },
                        new
                        {
                            CategoryId = 10,
                            FeatureId = 10
                        });
                });

            modelBuilder.Entity("Store.Domain.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6183),
                            IsDeleted = false,
                            Name = "Feature 1",
                            Type = 2,
                            Value = "false"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6225),
                            IsDeleted = false,
                            Name = "Feature 2",
                            Type = 3,
                            Value = "Value 2"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6234),
                            IsDeleted = false,
                            Name = "Feature 3",
                            Type = 1,
                            Value = "3"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6240),
                            IsDeleted = false,
                            Name = "Feature 4",
                            Type = 2,
                            Value = "true"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6246),
                            IsDeleted = false,
                            Name = "Feature 5",
                            Type = 3,
                            Value = "Value 5"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6258),
                            IsDeleted = false,
                            Name = "Feature 6",
                            Type = 1,
                            Value = "6"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6265),
                            IsDeleted = false,
                            Name = "Feature 7",
                            Type = 2,
                            Value = "false"
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6272),
                            IsDeleted = false,
                            Name = "Feature 8",
                            Type = 3,
                            Value = "Value 8"
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6324),
                            IsDeleted = false,
                            Name = "Feature 9",
                            Type = 1,
                            Value = "9"
                        },
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 688, DateTimeKind.Local).AddTicks(6333),
                            IsDeleted = false,
                            Name = "Feature 10",
                            Type = 2,
                            Value = "true"
                        });
                });

            modelBuilder.Entity("Store.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Code = "P001",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(249),
                            Description = "Description for Product 1",
                            ImgUrl = "URL for Product 1 Image",
                            IsDeleted = false,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Code = "P002",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(277),
                            Description = "Description for Product 2",
                            ImgUrl = "URL for Product 2 Image",
                            IsDeleted = false,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            Code = "P003",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(287),
                            Description = "Description for Product 3",
                            ImgUrl = "URL for Product 3 Image",
                            IsDeleted = false,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Code = "P004",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(297),
                            Description = "Description for Product 4",
                            ImgUrl = "URL for Product 4 Image",
                            IsDeleted = false,
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 6,
                            Code = "P005",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(307),
                            Description = "Description for Product 5",
                            ImgUrl = "URL for Product 5 Image",
                            IsDeleted = false,
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 7,
                            Code = "P006",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(317),
                            Description = "Description for Product 6",
                            ImgUrl = "URL for Product 6 Image",
                            IsDeleted = false,
                            Title = "Product 6"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 8,
                            Code = "P007",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(326),
                            Description = "Description for Product 7",
                            ImgUrl = "URL for Product 7 Image",
                            IsDeleted = false,
                            Title = "Product 7"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 9,
                            Code = "P008",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(335),
                            Description = "Description for Product 8",
                            ImgUrl = "URL for Product 8 Image",
                            IsDeleted = false,
                            Title = "Product 8"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 10,
                            Code = "P009",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(343),
                            Description = "Description for Product 9",
                            ImgUrl = "URL for Product 9 Image",
                            IsDeleted = false,
                            Title = "Product 9"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Code = "P0010",
                            CreateDate = new DateTime(2024, 2, 26, 23, 35, 15, 689, DateTimeKind.Local).AddTicks(354),
                            Description = "Description for Product 10",
                            ImgUrl = "URL for Product 10 Image",
                            IsDeleted = false,
                            Title = "Product 10"
                        });
                });

            modelBuilder.Entity("Store.Domain.ProductFeature", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("ProductFeatures");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            FeatureId = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 2,
                            FeatureId = 2,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 3,
                            FeatureId = 3,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 4,
                            FeatureId = 4,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 5,
                            FeatureId = 5,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 6,
                            FeatureId = 6,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 7,
                            FeatureId = 7,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 8,
                            FeatureId = 8,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 9,
                            FeatureId = 9,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        },
                        new
                        {
                            ProductId = 10,
                            FeatureId = 10,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 0,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Store.Domain.CategoryFeature", b =>
                {
                    b.HasOne("Store.Domain.Category", "Category")
                        .WithMany("CategoryFeatures")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store.Domain.Feature", "Feature")
                        .WithMany("CategoryFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("Store.Domain.Product", b =>
                {
                    b.HasOne("Store.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Store.Domain.ProductFeature", b =>
                {
                    b.HasOne("Store.Domain.Feature", "Feature")
                        .WithMany("ProductFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store.Domain.Product", "Product")
                        .WithMany("ProductFeatures")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store.Domain.Category", b =>
                {
                    b.Navigation("CategoryFeatures");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Store.Domain.Feature", b =>
                {
                    b.Navigation("CategoryFeatures");

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Store.Domain.Product", b =>
                {
                    b.Navigation("ProductFeatures");
                });
#pragma warning restore 612, 618
        }
    }
}
