using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Mesocycle : Migration
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

            migrationBuilder.CreateTable(
                name: "BodyParts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Size = table.Column<double>(type: "double precision", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesocycles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CurrentWeekIndex = table.Column<int>(type: "integer", nullable: false),
                    CurrentDayOfWeek = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesocycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FoodId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    BodyPartId = table.Column<Guid>(type: "uuid", nullable: false),
                    BodyWeightExercise = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_BodyParts_BodyPartId",
                        column: x => x.BodyPartId,
                        principalTable: "BodyParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Week",
                columns: table => new
                {
                    MesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeekIndex = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Week", x => new { x.MesocycleId, x.Id });
                    table.ForeignKey(
                        name: "FK_Week_Mesocycles_MesocycleId",
                        column: x => x.MesocycleId,
                        principalTable: "Mesocycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeFoodAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    Protein = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrate = table.Column<double>(type: "double precision", nullable: false),
                    Fat = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeFoodAmount", x => new { x.RecipeId, x.Id });
                    table.ForeignKey(
                        name: "FK_RecipeFoodAmount_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    WeekMesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    WeekId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DayOfWeek = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => new { x.WeekMesocycleId, x.WeekId, x.Id });
                    table.ForeignKey(
                        name: "FK_Workout_Week_WeekMesocycleId_WeekId",
                        columns: x => new { x.WeekMesocycleId, x.WeekId },
                        principalTable: "Week",
                        principalColumns: new[] { "MesocycleId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    WorkoutWeekMesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkoutWeekId = table.Column<int>(type: "integer", nullable: false),
                    WorkoutId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    TargetReps = table.Column<int>(type: "integer", nullable: false),
                    TargetWeight = table.Column<double>(type: "double precision", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => new { x.WorkoutWeekMesocycleId, x.WorkoutWeekId, x.WorkoutId, x.Id });
                    table.ForeignKey(
                        name: "FK_Set_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Set_Workout_WorkoutWeekMesocycleId_WorkoutWeekId_WorkoutId",
                        columns: x => new { x.WorkoutWeekMesocycleId, x.WorkoutWeekId, x.WorkoutId },
                        principalTable: "Workout",
                        principalColumns: new[] { "WeekMesocycleId", "WeekId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BodyParts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name", "Size" },
                values: new object[,]
                {
                    { new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2188), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2191), "Forearms", 1.0 },
                    { new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(1939), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2039), "Calves", 3.0 },
                    { new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2118), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2121), "Shoulders", 1.0 },
                    { new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2080), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2083), "Back", 4.0 },
                    { new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2125), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2127), "Hamstrings", 4.0 },
                    { new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2096), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2099), "Triceps", 3.0 },
                    { new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2104), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2106), "Chest", 2.0 },
                    { new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2146), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2148), "Neck", 1.0 },
                    { new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2139), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2142), "Glutes", 3.0 },
                    { new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2196), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2199), "Traps", 3.0 },
                    { new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2089), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2091), "Biceps", 1.0 },
                    { new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2112), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2114), "Abs", 2.0 },
                    { new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2131), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2133), "Quads", 4.0 },
                    { new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2204), null, new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2206), "Lower Back", 3.0 }
                });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("b00befc1-4316-4caa-97c6-0485aefee809"), 100, 100, 100, 10.0, new DateOnly(2025, 1, 21), 10.0, 1, 10.0 });

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
                values: new object[] { new Guid("90b3e928-d572-487c-924c-b0cad99b5a53"), null, new DateTime(2025, 1, 21, 18, 12, 54, 655, DateTimeKind.Utc).AddTicks(5667), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), "System", new DateTime(2025, 1, 21, 18, 12, 54, 661, DateTimeKind.Utc).AddTicks(6976), 1, 1, null, null, "Default Mesocycle" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 664, DateTimeKind.Utc).AddTicks(945), new DateTime(2025, 1, 21, 18, 12, 54, 664, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "BodyPartId", "BodyWeightExercise", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(791), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(794), "Calves Two Second Pause" },
                    { new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(778), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(780), "Calves Four Second Eccentric" },
                    { new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(805), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(808), "Lying Dumbell Bicep Curl" },
                    { new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), true, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(734), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(737), "Reverse Nordics" },
                    { new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(720), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(723), "Cable Crunch" },
                    { new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(642), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(645), "Bench Press" },
                    { new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(749), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(751), "DualCableRow" },
                    { new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(763), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(765), "RDL" },
                    { new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(820), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(823), "Lying Overhead Triceps Extension" },
                    { new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(865), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(867), "Single Arm Cable Lateral Raise" },
                    { new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(624), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(626), "Flyes" },
                    { new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(657), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(660), "Squat" },
                    { new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(672), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(675), "Deadlift" },
                    { new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(689), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(692), "Incline Dumbbell Press" },
                    { new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), false, null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(705), null, new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(708), "Pull Down" }
                });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("90b3e928-d572-487c-924c-b0cad99b5a53"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("90b3e928-d572-487c-924c-b0cad99b5a53"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("b00befc1-4316-4caa-97c6-0485aefee809"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("b00befc1-4316-4caa-97c6-0485aefee809"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), 1 },
                    { 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), 3 },
                    { 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), 5 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10 },
                    { 2, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10 },
                    { 3, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 5.0, 10 },
                    { 4, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10 },
                    { 5, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 6, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 7, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 8, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 9, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 },
                    { 10, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10 },
                    { 11, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 46.5, 10 },
                    { 12, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10 },
                    { 13, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 41.5, 10 },
                    { 14, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 15, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 16, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 17, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 18, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 },
                    { 19, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 15, 16.0, 10 },
                    { 20, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10 },
                    { 21, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10 },
                    { 22, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10 },
                    { 23, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 24, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 25, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 26, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 27, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_BodyPartId",
                table: "Exercises",
                column: "BodyPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Set_ExerciseId",
                table: "Set",
                column: "ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeFoodAmount");

            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "BodyParts");

            migrationBuilder.DropTable(
                name: "Week");

            migrationBuilder.DropTable(
                name: "Mesocycles");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("b00befc1-4316-4caa-97c6-0485aefee809"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("90b3e928-d572-487c-924c-b0cad99b5a53"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("90b3e928-d572-487c-924c-b0cad99b5a53"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("90b3e928-d572-487c-924c-b0cad99b5a53"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("b00befc1-4316-4caa-97c6-0485aefee809"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b00befc1-4316-4caa-97c6-0485aefee809"));

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Food");

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
