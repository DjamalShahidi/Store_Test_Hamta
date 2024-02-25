using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Store.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 298, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.InsertData(
                table: "CategoryFeatures",
                columns: new[] { "CategoryId", "FeatureId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 25, 20, 3, 9, 299, DateTimeKind.Local).AddTicks(6413));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryFeatures",
                keyColumns: new[] { "CategoryId", "FeatureId" },
                keyValues: new object[] { 10, 10 });

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
    }
}
