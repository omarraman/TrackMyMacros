using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class starting_value_for_food_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("78e3cc81-d047-4fef-81f8-e6944c9590d1"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("8ff6a969-412f-4f69-9585-bdbc3871e60b"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("8ff6a969-412f-4f69-9585-bdbc3871e60b"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("8ff6a969-412f-4f69-9585-bdbc3871e60b"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("78e3cc81-d047-4fef-81f8-e6944c9590d1"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("78e3cc81-d047-4fef-81f8-e6944c9590d1"));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Food",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Food",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 5, 11, 51, 740, DateTimeKind.Utc).AddTicks(3528), new DateTime(2024, 3, 28, 5, 11, 51, 740, DateTimeKind.Utc).AddTicks(3685) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("78e3cc81-d047-4fef-81f8-e6944c9590d1"), 100, 100, 100, 10.0, new DateOnly(2024, 3, 28), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("8ff6a969-412f-4f69-9585-bdbc3871e60b"), null, new DateTime(2024, 3, 28, 5, 11, 51, 753, DateTimeKind.Utc).AddTicks(1306), null, null, "Test Food Combo" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 5, 11, 51, 757, DateTimeKind.Utc).AddTicks(2233), new DateTime(2024, 3, 28, 5, 11, 51, 757, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("8ff6a969-412f-4f69-9585-bdbc3871e60b"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("8ff6a969-412f-4f69-9585-bdbc3871e60b"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("78e3cc81-d047-4fef-81f8-e6944c9590d1"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("78e3cc81-d047-4fef-81f8-e6944c9590d1"), 1, 10.0, 10.0, 3, 10.0, 100.0 });
        }
    }
}
