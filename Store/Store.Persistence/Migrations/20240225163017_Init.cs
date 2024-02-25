using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Store.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFeatures",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFeatures", x => new { x.CategoryId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_CategoryFeatures_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => new { x.ProductId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9743), false, "Category 1" },
                    { 2, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9813), false, "Category 2" },
                    { 3, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9824), false, "Category 3" },
                    { 4, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9833), false, "Category 4" },
                    { 5, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9842), false, "Category 5" },
                    { 6, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9854), false, "Category 6" },
                    { 7, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9861), false, "Category 7" },
                    { 8, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9870), false, "Category 8" },
                    { 9, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9878), false, "Category 9" },
                    { 10, new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9890), false, "Category 10" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name", "Type", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4349), false, "Feature 1", 2, "false" },
                    { 2, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4398), false, "Feature 2", 3, "Value 2" },
                    { 3, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4410), false, "Feature 3", 1, "3" },
                    { 4, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4417), false, "Feature 4", 2, "true" },
                    { 5, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4425), false, "Feature 5", 3, "Value 5" },
                    { 6, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4436), false, "Feature 6", 1, "6" },
                    { 7, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4445), false, "Feature 7", 2, "false" },
                    { 8, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4452), false, "Feature 8", 3, "Value 8" },
                    { 9, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4460), false, "Feature 9", 1, "9" },
                    { 10, new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4467), false, "Feature 10", 2, "true" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Code", "CreateDate", "Description", "ImgUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 2, "P001", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9022), "Description for Product 1", "URL for Product 1 Image", false, "Product 1" },
                    { 2, 3, "P002", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9112), "Description for Product 2", "URL for Product 2 Image", false, "Product 2" },
                    { 3, 4, "P003", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9125), "Description for Product 3", "URL for Product 3 Image", false, "Product 3" },
                    { 4, 5, "P004", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9135), "Description for Product 4", "URL for Product 4 Image", false, "Product 4" },
                    { 5, 6, "P005", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9144), "Description for Product 5", "URL for Product 5 Image", false, "Product 5" },
                    { 6, 7, "P006", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9157), "Description for Product 6", "URL for Product 6 Image", false, "Product 6" },
                    { 7, 8, "P007", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9165), "Description for Product 7", "URL for Product 7 Image", false, "Product 7" },
                    { 8, 9, "P008", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9174), "Description for Product 8", "URL for Product 8 Image", false, "Product 8" },
                    { 9, 10, "P009", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9183), "Description for Product 9", "URL for Product 9 Image", false, "Product 9" },
                    { 10, 1, "P0010", new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9195), "Description for Product 10", "URL for Product 10 Image", false, "Product 10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFeatures_FeatureId",
                table: "CategoryFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_FeatureId",
                table: "ProductFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryFeatures");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
