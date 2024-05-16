using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class WeightReading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("64e7844b-dcea-4d89-b199-97dc95bef1e1"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("16efaa9d-fc3f-4222-9de5-6238398ecc54"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("16efaa9d-fc3f-4222-9de5-6238398ecc54"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("16efaa9d-fc3f-4222-9de5-6238398ecc54"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("64e7844b-dcea-4d89-b199-97dc95bef1e1"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("64e7844b-dcea-4d89-b199-97dc95bef1e1"));

            migrationBuilder.CreateTable(
                name: "WeightReadings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightReadings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 4, 35, 57, 821, DateTimeKind.Utc).AddTicks(1297), new DateTime(2024, 5, 16, 4, 35, 57, 821, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("5ae5e9ad-10a9-4126-9412-06e00b8b7a59"), 100, 100, 100, 10.0, new DateOnly(2024, 5, 16), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("410f7035-81d3-4d11-9148-3c6f6659d2ac"), null, new DateTime(2024, 5, 16, 4, 35, 57, 828, DateTimeKind.Utc).AddTicks(9422), null, null, "Test Food Combo" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 4, 35, 57, 830, DateTimeKind.Utc).AddTicks(6230), new DateTime(2024, 5, 16, 4, 35, 57, 830, DateTimeKind.Utc).AddTicks(6263) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("410f7035-81d3-4d11-9148-3c6f6659d2ac"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("410f7035-81d3-4d11-9148-3c6f6659d2ac"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("5ae5e9ad-10a9-4126-9412-06e00b8b7a59"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("5ae5e9ad-10a9-4126-9412-06e00b8b7a59"), 1, 10.0, 10.0, 3, 10.0, 100.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeightReadings");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("5ae5e9ad-10a9-4126-9412-06e00b8b7a59"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("410f7035-81d3-4d11-9148-3c6f6659d2ac"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("410f7035-81d3-4d11-9148-3c6f6659d2ac"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("410f7035-81d3-4d11-9148-3c6f6659d2ac"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("5ae5e9ad-10a9-4126-9412-06e00b8b7a59"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("5ae5e9ad-10a9-4126-9412-06e00b8b7a59"));

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 10, 53, 34, 304, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 5, 10, 10, 53, 34, 304, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("64e7844b-dcea-4d89-b199-97dc95bef1e1"), 100, 100, 100, 10.0, new DateOnly(2024, 5, 10), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("16efaa9d-fc3f-4222-9de5-6238398ecc54"), null, new DateTime(2024, 5, 10, 10, 53, 34, 311, DateTimeKind.Utc).AddTicks(9221), null, null, "Test Food Combo" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 10, 53, 34, 313, DateTimeKind.Utc).AddTicks(5753), new DateTime(2024, 5, 10, 10, 53, 34, 313, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("16efaa9d-fc3f-4222-9de5-6238398ecc54"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("16efaa9d-fc3f-4222-9de5-6238398ecc54"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("64e7844b-dcea-4d89-b199-97dc95bef1e1"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("64e7844b-dcea-4d89-b199-97dc95bef1e1"), 1, 10.0, 10.0, 3, 10.0, 100.0 });
        }
    }
}
