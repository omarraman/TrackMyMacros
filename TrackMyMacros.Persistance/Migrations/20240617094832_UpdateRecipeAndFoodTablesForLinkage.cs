using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRecipeAndFoodTablesForLinkage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeFoodAmount_Recipes_RecipeId",
                table: "RecipeFoodAmount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeFoodAmount",
                table: "RecipeFoodAmount");

            migrationBuilder.DropIndex(
                name: "IX_RecipeFoodAmount_RecipeId",
                table: "RecipeFoodAmount");

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

            migrationBuilder.AddColumn<Guid>(
                name: "FoodId",
                table: "Recipes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "RecipeId",
                table: "RecipeFoodAmount",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Food",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecipeId",
                table: "Food",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeFoodAmount",
                table: "RecipeFoodAmount",
                columns: new[] { "RecipeId", "Id" });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 17, 9, 48, 31, 802, DateTimeKind.Utc).AddTicks(2312), new DateTime(2024, 6, 17, 9, 48, 31, 802, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"), 100, 100, 100, 10.0, new DateOnly(2024, 6, 17), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Guid", "RecipeId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"), null, new DateTime(2024, 6, 17, 9, 48, 31, 813, DateTimeKind.Utc).AddTicks(1924), null, null, "Test Food Combo" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 17, 9, 48, 31, 818, DateTimeKind.Utc).AddTicks(921), new DateTime(2024, 6, 17, 9, 48, 31, 818, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeFoodAmount_Recipes_RecipeId",
                table: "RecipeFoodAmount",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeFoodAmount_Recipes_RecipeId",
                table: "RecipeFoodAmount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeFoodAmount",
                table: "RecipeFoodAmount");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"));

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Food");

            migrationBuilder.AlterColumn<Guid>(
                name: "RecipeId",
                table: "RecipeFoodAmount",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeFoodAmount",
                table: "RecipeFoodAmount",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeFoodAmount_Recipes_RecipeId",
                table: "RecipeFoodAmount",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");
        }
    }
}
