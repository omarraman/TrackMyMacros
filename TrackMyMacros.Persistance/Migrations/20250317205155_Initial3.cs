using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Guid = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CarbohydrateAmount = table.Column<double>(type: "double precision", nullable: false),
                    ProteinAmount = table.Column<double>(type: "double precision", nullable: false),
                    FatAmount = table.Column<double>(type: "double precision", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    QuantityInGrams = table.Column<int>(type: "integer", nullable: false),
                    DefaultQuantity = table.Column<double>(type: "double precision", nullable: true),
                    Min = table.Column<double>(type: "double precision", nullable: true),
                    Max = table.Column<double>(type: "double precision", nullable: true),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false),
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
                name: "Mesocycles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TotalWeeks = table.Column<int>(type: "integer", nullable: false),
                    Complete = table.Column<bool>(type: "boolean", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    WeightIncrease = table.Column<double>(type: "double precision", nullable: false),
                    RepIncrease = table.Column<int>(type: "integer", nullable: false),
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
                name: "SetGroup",
                columns: table => new
                {
                    WorkoutWeekMesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkoutWeekId = table.Column<int>(type: "integer", nullable: false),
                    WorkoutId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetGroup", x => new { x.WorkoutWeekMesocycleId, x.WorkoutWeekId, x.WorkoutId, x.Id });
                    table.ForeignKey(
                        name: "FK_SetGroup_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetGroup_Workout_WorkoutWeekMesocycleId_WorkoutWeekId_Worko~",
                        columns: x => new { x.WorkoutWeekMesocycleId, x.WorkoutWeekId, x.WorkoutId },
                        principalTable: "Workout",
                        principalColumns: new[] { "WeekMesocycleId", "WeekId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    SetGroupWorkoutWeekMesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    SetGroupWorkoutWeekId = table.Column<int>(type: "integer", nullable: false),
                    SetGroupWorkoutId = table.Column<int>(type: "integer", nullable: false),
                    SetGroupId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    TargetReps = table.Column<int>(type: "integer", nullable: false),
                    TargetWeight = table.Column<double>(type: "double precision", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => new { x.SetGroupWorkoutWeekMesocycleId, x.SetGroupWorkoutWeekId, x.SetGroupWorkoutId, x.SetGroupId, x.Id });
                    table.ForeignKey(
                        name: "FK_Set_SetGroup_SetGroupWorkoutWeekMesocycleId_SetGroupWorkout~",
                        columns: x => new { x.SetGroupWorkoutWeekMesocycleId, x.SetGroupWorkoutWeekId, x.SetGroupWorkoutId, x.SetGroupId },
                        principalTable: "SetGroup",
                        principalColumns: new[] { "WorkoutWeekMesocycleId", "WorkoutWeekId", "WorkoutId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BodyParts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name", "Size" },
                values: new object[,]
                {
                    { new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6738), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6740), "Forearms", 1.0 },
                    { new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6616), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6655), "Calves", 3.0 },
                    { new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6709), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6710), "Shoulders", 1.0 },
                    { new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6679), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6681), "Back", 4.0 },
                    { new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6715), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6717), "Hamstrings", 4.0 },
                    { new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6691), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6693), "Triceps", 3.0 },
                    { new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6696), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6698), "Chest", 2.0 },
                    { new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6733), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6735), "Neck", 1.0 },
                    { new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6727), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6729), "Glutes", 3.0 },
                    { new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6743), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6745), "Traps", 3.0 },
                    { new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6685), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6687), "Biceps", 1.0 },
                    { new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6704), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6705), "Abs", 2.0 },
                    { new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6722), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6723), "Quads", 4.0 },
                    { new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6748), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6750), "Lower Back", 3.0 }
                });

            migrationBuilder.InsertData(
                table: "DailyLimits",
                columns: new[] { "Id", "Calories", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "WeekdaysMealsPerDay", "WeekendMealsPerDay", "WeightInKg" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), 2400, null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(8292), null, new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(8311), 5, 5, 75.900000000000006 });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("71a5c095-c291-45c5-ae00-6182c998166e"), 100, 100, 100, 10.0, new DateOnly(2025, 3, 17), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CarbohydrateAmount", "DefaultQuantity", "FatAmount", "Guid", "Max", "Min", "Name", "ProteinAmount", "Quantity", "QuantityInGrams", "RecipeId", "UomId" },
                values: new object[,]
                {
                    { 1, 11.0, null, 5.0, null, null, null, "Peanut Butter", 20.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 2, 40.0, null, 8.0, null, null, null, "Hovis", 10.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 3, 14.0, null, 0.29999999999999999, null, null, null, "Apple", 0.29999999999999999, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 4, 5.5, null, 3.1000000000000001, null, null, null, "Arrabiata Sauce Barilla", 1.3999999999999999, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 5, 4.0, 40.0, 0.20000000000000001, null, null, null, "Arla Kvarg Vanilj", 9.6999999999999993, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 6, 23.0, null, 0.10000000000000001, null, null, null, "Banana", 1.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 7, 52.0, null, 0.10000000000000001, null, null, null, "Basmati Rice", 5.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 8, 7.5999999999999996, null, 0.5, null, null, null, "Blueberries", 0.5, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 9, 65.0, null, 2.2000000000000002, null, null, null, "Bran Flakes", 11.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 10, 44.0, 80.0, 4.0, null, null, null, "Bread", 10.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 11, 0.40000000000000002, null, 75.0, null, null, null, "Breggott", 0.40000000000000002, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 12, 76.0, null, 1.3, null, null, null, "Bulgur", 12.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 13, 0.10000000000000001, null, 0.10000000000000001, null, null, null, "Chicken Breast", 23.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 14, 6.5, 255.0, 1.5, null, null, null, "Chilli", 7.7999999999999998, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 15, 26.0, 40.0, 0.80000000000000004, null, null, null, "Weetabix", 4.5, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 16, 3.1000000000000001, 170.0, 1.5, null, null, null, "Milk", 3.2999999999999998, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 17, 77.0, null, 0.10000000000000001, null, null, null, "Raisins", 2.5, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 18, 4.2999999999999998, 40.0, 21.0, null, null, null, "Philadelphia", 5.4000000000000004, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 19, 38.0, null, 113.0, null, null, null, "Huel", 29.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 20, 0.10000000000000001, null, 0.10000000000000001, null, null, null, "Chicken Breast", 23.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 21, 28.84, null, 0.40000000000000002, null, null, null, "Bulgur Cooked", 4.7999999999999998, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 22, 55.0, null, 4.9000000000000004, null, null, null, "Tortilla", 8.3000000000000007, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 23, 0.0, null, 100.0, null, null, null, "Oil", 0.0, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 24, 6.4000000000000004, null, 0.5, null, null, null, "Frozen Strawberries", 0.5, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 25, 50.0, null, 15.0, null, null, null, "Granola", 0.69999999999999996, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { 26, 0.10000000000000001, null, 32.0, null, null, null, "Kilmeaden", 25.5, 100.0, 100, new Guid("00000000-0000-0000-0000-000000000000"), 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("37680512-b27f-4573-b890-610a9edf73b5"), null, new DateTime(2025, 3, 17, 20, 51, 55, 857, DateTimeKind.Utc).AddTicks(1655), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "Complete", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name", "TotalWeeks" },
                values: new object[] { new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), false, "System", new DateTime(2025, 3, 17, 20, 51, 55, 864, DateTimeKind.Utc).AddTicks(5980), 1, 1, null, null, "Default Mesocycle", 5 });

            migrationBuilder.InsertData(
                table: "Uoms",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1, null, new DateTime(2025, 3, 17, 20, 51, 55, 866, DateTimeKind.Utc).AddTicks(9535), null, new DateTime(2025, 3, 17, 20, 51, 55, 866, DateTimeKind.Utc).AddTicks(9556), "Grams" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "BodyPartId", "BodyWeightExercise", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name", "RepIncrease", "WeightIncrease" },
                values: new object[,]
                {
                    { new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1698), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1699), "Calves Two Second Pause", 0, 1.0 },
                    { new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1690), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1692), "Calves Four Second Eccentric", 0, 1.0 },
                    { new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1706), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1708), "Lying Dumbell Bicep Curl", 0, 0.25 },
                    { new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), true, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1666), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1668), "Reverse Nordics", 1, 0.0 },
                    { new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1656), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1658), "Cable Crunch", 0, 0.25 },
                    { new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1607), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1609), "Bench Press", 0, 0.5 },
                    { new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1675), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1676), "DualCableRow", 0, 1.0 },
                    { new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1681), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1682), "RDL", 0, 1.25 },
                    { new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1714), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1716), "Lying Overhead Triceps Extension", 0, 0.25 },
                    { new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1723), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1725), "Single Arm Cable Lateral Raise", 0, 0.25 },
                    { new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1592), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1594), "Flyes", 0, 0.5 },
                    { new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1618), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1619), "Squat", 0, 1.25 },
                    { new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1627), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1628), "Deadlift", 0, 1.25 },
                    { new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1635), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1637), "Incline Dumbbell Press", 0, 0.5 },
                    { new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), false, null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1645), null, new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1647), "Pull Down", 0, 1.25 }
                });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("37680512-b27f-4573-b890-610a9edf73b5"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("37680512-b27f-4573-b890-610a9edf73b5"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("71a5c095-c291-45c5-ae00-6182c998166e"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("71a5c095-c291-45c5-ae00-6182c998166e"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1 },
                    { 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 3 },
                    { 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 5 }
                });

            migrationBuilder.InsertData(
                table: "SetGroup",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Priority" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1 },
                    { 2, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 2 },
                    { 3, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 3 },
                    { 4, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 4 },
                    { 5, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 5 },
                    { 6, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 6 },
                    { 7, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 7 },
                    { 8, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 8 },
                    { 9, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 9 },
                    { 10, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1 },
                    { 11, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 2 },
                    { 12, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 3 },
                    { 13, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 4 },
                    { 14, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 5 },
                    { 15, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 6 },
                    { 16, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 7 },
                    { 17, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 8 },
                    { 18, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 9 },
                    { 19, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1 },
                    { 20, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 2 },
                    { 21, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 3 },
                    { 22, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 4 },
                    { 23, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 5 },
                    { 24, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 6 },
                    { 25, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 7 },
                    { 26, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 8 },
                    { 27, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 9 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId", "Number", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 14, 21.0, 10.0 },
                    { 2, 2, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 12, 51.5, 10.0 },
                    { 3, 3, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 8, 52.5, 10.0 },
                    { 4, 4, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 11, 42.0, 10.0 },
                    { 5, 5, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 8, 9.0, 10.0 },
                    { 6, 6, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 8, 14.5, 10.0 },
                    { 7, 7, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 5, 100.0, 10.0 },
                    { 8, 8, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 7, 14.5, 10.0 },
                    { 9, 9, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 6, 14.5, 10.0 },
                    { 10, 10, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 14, 16.75, 16.75 },
                    { 11, 11, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 10, 24.5, 24.5 },
                    { 12, 12, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 9, 47.25, 47.25 },
                    { 13, 13, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 7, 47.25, 10.0 },
                    { 14, 14, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 8, 10.5, 10.5 },
                    { 15, 15, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 8, 14.75, 10.0 },
                    { 16, 16, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 5, 100.0, 10.0 },
                    { 17, 17, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 7, 14.75, 10.0 },
                    { 18, 18, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 6, 14.75, 10.0 },
                    { 19, 19, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 14, 16.75, 10.0 },
                    { 20, 20, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 14, 51.450000000000003, 10.0 },
                    { 21, 21, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 9, 47.25, 10.0 },
                    { 22, 22, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 10, 47.25, 10.0 },
                    { 23, 23, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 8, 10.5, 10.0 },
                    { 24, 24, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 10, 14.75, 10.0 },
                    { 25, 25, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 5, 100.0, 10.0 },
                    { 26, 26, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 7, 14.75, 10.0 },
                    { 27, 27, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), 1, 0, 6, 14.75, 10.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_BodyPartId",
                table: "Exercises",
                column: "BodyPartId");

            migrationBuilder.CreateIndex(
                name: "IX_SetGroup_ExerciseId",
                table: "SetGroup",
                column: "ExerciseId");
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
                name: "RecipeFoodAmount");

            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropTable(
                name: "Uoms");

            migrationBuilder.DropTable(
                name: "WeightReadings");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "FoodCombos");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "SetGroup");

            migrationBuilder.DropTable(
                name: "Days");

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
        }
    }
}
