using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Add_min_max_to_food : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<double>(
                name: "Max",
                table: "Food",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Min",
                table: "Food",
                type: "double precision",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 31, 4, 22, 3, 915, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 5, 31, 4, 22, 3, 915, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("4c65d788-f4d4-46b7-83ab-4a52c12b7ae1"), 100, 100, 100, 10.0, new DateOnly(2024, 5, 31), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Max", "Min" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("76ecf581-ed7e-436e-9870-d57ad7ae6353"), null, new DateTime(2024, 5, 31, 4, 22, 3, 926, DateTimeKind.Utc).AddTicks(2498), null, null, "Test Food Combo" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 31, 4, 22, 3, 928, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 5, 31, 4, 22, 3, 928, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("76ecf581-ed7e-436e-9870-d57ad7ae6353"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("76ecf581-ed7e-436e-9870-d57ad7ae6353"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("4c65d788-f4d4-46b7-83ab-4a52c12b7ae1"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("4c65d788-f4d4-46b7-83ab-4a52c12b7ae1"), 1, 10.0, 10.0, 3, 10.0, 100.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("4c65d788-f4d4-46b7-83ab-4a52c12b7ae1"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("76ecf581-ed7e-436e-9870-d57ad7ae6353"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("76ecf581-ed7e-436e-9870-d57ad7ae6353"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("76ecf581-ed7e-436e-9870-d57ad7ae6353"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("4c65d788-f4d4-46b7-83ab-4a52c12b7ae1"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("4c65d788-f4d4-46b7-83ab-4a52c12b7ae1"));

            migrationBuilder.DropColumn(
                name: "Max",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "Min",
                table: "Food");

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
    }
}
