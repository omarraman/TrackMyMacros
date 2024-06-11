using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addrecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeFoodAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    Protein = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrate = table.Column<double>(type: "double precision", nullable: false),
                    Fat = table.Column<double>(type: "double precision", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeFoodAmount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeFoodAmount_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 6, 37, 55, 106, DateTimeKind.Utc).AddTicks(1553), new DateTime(2024, 6, 9, 6, 37, 55, 106, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("8c8e1bd7-bcda-4385-a456-1db2d5ccfaa3"), 100, 100, 100, 10.0, new DateOnly(2024, 6, 9), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("1ecbfe22-7866-4967-a8cb-c8fe4d9ccdcc"), null, new DateTime(2024, 6, 9, 6, 37, 55, 113, DateTimeKind.Utc).AddTicks(755), null, null, "Test Food Combo" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 6, 37, 55, 114, DateTimeKind.Utc).AddTicks(4201), new DateTime(2024, 6, 9, 6, 37, 55, 114, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1ecbfe22-7866-4967-a8cb-c8fe4d9ccdcc"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("1ecbfe22-7866-4967-a8cb-c8fe4d9ccdcc"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("8c8e1bd7-bcda-4385-a456-1db2d5ccfaa3"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("8c8e1bd7-bcda-4385-a456-1db2d5ccfaa3"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeFoodAmount_RecipeId",
                table: "RecipeFoodAmount",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeFoodAmount");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("8c8e1bd7-bcda-4385-a456-1db2d5ccfaa3"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("1ecbfe22-7866-4967-a8cb-c8fe4d9ccdcc"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("1ecbfe22-7866-4967-a8cb-c8fe4d9ccdcc"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("1ecbfe22-7866-4967-a8cb-c8fe4d9ccdcc"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("8c8e1bd7-bcda-4385-a456-1db2d5ccfaa3"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("8c8e1bd7-bcda-4385-a456-1db2d5ccfaa3"));

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
    }
}
