using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyLimits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Calories = table.Column<int>(type: "integer", nullable: false),
                    WeightInKg = table.Column<double>(type: "double precision", nullable: false),
                    WeekdaysMealsPerDay = table.Column<int>(type: "integer", nullable: false),
                    WeekendMealsPerDay = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyLimits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Protein = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrate = table.Column<double>(type: "double precision", nullable: false),
                    Fat = table.Column<double>(type: "double precision", nullable: false),
                    AllowedProtein = table.Column<int>(type: "integer", nullable: false),
                    AllowedCarbohydrate = table.Column<int>(type: "integer", nullable: false),
                    AllowedFat = table.Column<int>(type: "integer", nullable: false),
                    MealCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CarbohydrateAmount = table.Column<double>(type: "double precision", nullable: false),
                    ProteinAmount = table.Column<double>(type: "double precision", nullable: false),
                    FatAmount = table.Column<double>(type: "double precision", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    QuantityInGrams = table.Column<int>(type: "integer", nullable: false),
                    DefaultQuantity = table.Column<double>(type: "double precision", nullable: true),
                    UomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCombos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCombos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uoms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    DayId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Protein = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrate = table.Column<double>(type: "double precision", nullable: false),
                    Fat = table.Column<double>(type: "double precision", nullable: false),
                    AllowedProtein = table.Column<int>(type: "integer", nullable: false),
                    AllowedCarbohydrate = table.Column<int>(type: "integer", nullable: false),
                    AllowedFat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => new { x.DayId, x.Id });
                    table.ForeignKey(
                        name: "FK_Meal_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodComboAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FoodComboId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    Protein = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrate = table.Column<double>(type: "double precision", nullable: false),
                    Fat = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodComboAmount", x => new { x.FoodComboId, x.Id });
                    table.ForeignKey(
                        name: "FK_FoodComboAmount_FoodCombos_FoodComboId",
                        column: x => x.FoodComboId,
                        principalTable: "FoodCombos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodAmount",
                columns: table => new
                {
                    MealDayId = table.Column<Guid>(type: "uuid", nullable: false),
                    MealId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    Protein = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrate = table.Column<double>(type: "double precision", nullable: false),
                    Fat = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAmount", x => new { x.MealDayId, x.MealId, x.Id });
                    table.ForeignKey(
                        name: "FK_FoodAmount_Meal_MealDayId_MealId",
                        columns: x => new { x.MealDayId, x.MealId },
                        principalTable: "Meal",
                        principalColumns: new[] { "DayId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DailyLimits",
                columns: new[] { "Id", "Calories", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "WeekdaysMealsPerDay", "WeekendMealsPerDay", "WeightInKg" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), 2400, null, new DateTime(2024, 3, 28, 5, 11, 51, 740, DateTimeKind.Utc).AddTicks(3528), null, new DateTime(2024, 3, 28, 5, 11, 51, 740, DateTimeKind.Utc).AddTicks(3685), 5, 5, 75.900000000000006 });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("78e3cc81-d047-4fef-81f8-e6944c9590d1"), 100, 100, 100, 10.0, new DateOnly(2024, 3, 28), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CarbohydrateAmount", "DefaultQuantity", "FatAmount", "Name", "ProteinAmount", "Quantity", "QuantityInGrams", "UomId" },
                values: new object[,]
                {
                    { 1, 11.0, null, 5.0, "Peanut Butter", 20.0, 100.0, 100, 1 },
                    { 2, 40.0, null, 8.0, "Hovis", 10.0, 100.0, 100, 1 },
                    { 3, 14.0, null, 0.29999999999999999, "Apple", 0.29999999999999999, 100.0, 100, 1 },
                    { 4, 5.5, null, 3.1000000000000001, "Arrabiata Sauce Barilla", 1.3999999999999999, 100.0, 100, 1 },
                    { 5, 4.0, 40.0, 0.20000000000000001, "Arla Kvarg Vanilj", 9.6999999999999993, 100.0, 100, 1 },
                    { 6, 23.0, null, 0.10000000000000001, "Banana", 1.0, 100.0, 100, 1 },
                    { 7, 52.0, null, 0.10000000000000001, "Basmati Rice", 5.0, 100.0, 100, 1 },
                    { 8, 7.5999999999999996, null, 0.5, "Blueberries", 0.5, 100.0, 100, 1 },
                    { 9, 65.0, null, 2.2000000000000002, "Bran Flakes", 11.0, 100.0, 100, 1 },
                    { 10, 44.0, 80.0, 4.0, "Bread", 10.0, 100.0, 100, 1 },
                    { 11, 0.40000000000000002, null, 75.0, "Breggott", 0.40000000000000002, 100.0, 100, 1 },
                    { 12, 76.0, null, 1.3, "Bulgur", 12.0, 100.0, 100, 1 },
                    { 13, 0.10000000000000001, null, 0.10000000000000001, "Chicken Breast", 23.0, 100.0, 100, 1 },
                    { 14, 6.5, 255.0, 1.5, "Chilli", 7.7999999999999998, 100.0, 100, 1 },
                    { 15, 26.0, 40.0, 0.80000000000000004, "Weetabix", 4.5, 100.0, 100, 1 },
                    { 16, 3.1000000000000001, 170.0, 1.5, "Milk", 3.2999999999999998, 100.0, 100, 1 },
                    { 17, 77.0, null, 0.10000000000000001, "Raisins", 2.5, 100.0, 100, 1 },
                    { 18, 4.2999999999999998, 40.0, 21.0, "Philadelphia", 5.4000000000000004, 100.0, 100, 1 },
                    { 19, 38.0, null, 113.0, "Huel", 29.0, 100.0, 100, 1 },
                    { 20, 0.10000000000000001, null, 0.10000000000000001, "Chicken Breast", 23.0, 100.0, 100, 1 },
                    { 21, 28.84, null, 0.40000000000000002, "Bulgur Cooked", 4.7999999999999998, 100.0, 100, 1 },
                    { 22, 55.0, null, 4.9000000000000004, "Tortilla", 8.3000000000000007, 100.0, 100, 1 },
                    { 23, 0.0, null, 100.0, "Oil", 0.0, 100.0, 100, 1 },
                    { 24, 6.4000000000000004, null, 0.5, "Frozen Strawberries", 0.5, 100.0, 100, 1 },
                    { 25, 50.0, null, 15.0, "Granola", 0.69999999999999996, 100.0, 100, 1 },
                    { 26, 0.10000000000000001, null, 32.0, "Kilmeaden", 25.5, 100.0, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("8ff6a969-412f-4f69-9585-bdbc3871e60b"), null, new DateTime(2024, 3, 28, 5, 11, 51, 753, DateTimeKind.Utc).AddTicks(1306), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Uoms",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1, null, new DateTime(2024, 3, 28, 5, 11, 51, 757, DateTimeKind.Utc).AddTicks(2233), null, new DateTime(2024, 3, 28, 5, 11, 51, 757, DateTimeKind.Utc).AddTicks(2636), "Grams" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyLimits");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "FoodAmount");

            migrationBuilder.DropTable(
                name: "FoodComboAmount");

            migrationBuilder.DropTable(
                name: "Uoms");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "FoodCombos");

            migrationBuilder.DropTable(
                name: "Days");
        }
    }
}
