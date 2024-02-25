using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Store.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 859, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "FeatureId", "ProductId", "CreateDate", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 5, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 6, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 7, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 8, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 9, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false },
                    { 10, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 42, 860, DateTimeKind.Local).AddTicks(8222));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 824, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 0, 15, 826, DateTimeKind.Local).AddTicks(9195));
        }
    }
}
