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
                name: "MesoCycle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MesoCycle", x => x.Id);
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
                name: "MicroCycle",
                columns: table => new
                {
                    MesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeekIndex = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicroCycle", x => new { x.MesocycleId, x.Id });
                    table.ForeignKey(
                        name: "FK_MicroCycle_MesoCycle_MesocycleId",
                        column: x => x.MesocycleId,
                        principalTable: "MesoCycle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseDay",
                columns: table => new
                {
                    MicroCycleMesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    MicroCycleId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DayOfWeek = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseDay", x => new { x.MicroCycleMesocycleId, x.MicroCycleId, x.Id });
                    table.ForeignKey(
                        name: "FK_ExerciseDay_MicroCycle_MicroCycleMesocycleId_MicroCycleId",
                        columns: x => new { x.MicroCycleMesocycleId, x.MicroCycleId },
                        principalTable: "MicroCycle",
                        principalColumns: new[] { "MesocycleId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseSet",
                columns: table => new
                {
                    ExerciseDayMicroCycleMesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseDayMicroCycleId = table.Column<int>(type: "integer", nullable: false),
                    ExerciseDayId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    TargetReps = table.Column<int>(type: "integer", nullable: false),
                    TargetWeight = table.Column<double>(type: "double precision", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseSet", x => new { x.ExerciseDayMicroCycleMesocycleId, x.ExerciseDayMicroCycleId, x.ExerciseDayId, x.Id });
                    table.ForeignKey(
                        name: "FK_ExerciseSet_ExerciseDay_ExerciseDayMicroCycleMesocycleId_Ex~",
                        columns: x => new { x.ExerciseDayMicroCycleMesocycleId, x.ExerciseDayMicroCycleId, x.ExerciseDayId },
                        principalTable: "ExerciseDay",
                        principalColumns: new[] { "MicroCycleMesocycleId", "MicroCycleId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BodyParts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name", "Size" },
                values: new object[,]
                {
                    { new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8720), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8723), "Forearms", 1.0 },
                    { new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8513), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8613), "Calves", 3.0 },
                    { new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8688), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8690), "Shoulders", 1.0 },
                    { new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8652), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8654), "Back", 4.0 },
                    { new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8695), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8698), "Hamstrings", 4.0 },
                    { new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8668), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8670), "Triceps", 3.0 },
                    { new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8674), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8677), "Chest", 2.0 },
                    { new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8714), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8716), "Neck", 1.0 },
                    { new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8708), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8710), "Glutes", 3.0 },
                    { new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8727), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8730), "Traps", 3.0 },
                    { new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8660), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8663), "Biceps", 1.0 },
                    { new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8682), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8684), "Abs", 2.0 },
                    { new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8701), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8704), "Quads", 4.0 },
                    { new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8733), null, new DateTime(2024, 12, 26, 8, 24, 3, 238, DateTimeKind.Utc).AddTicks(8736), "Lower Back", 3.0 }
                });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 24, 3, 239, DateTimeKind.Utc).AddTicks(419), new DateTime(2024, 12, 26, 8, 24, 3, 239, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("f381e984-db01-46a4-8d03-6e502ddb908e"), 100, 100, 100, 10.0, new DateOnly(2024, 12, 26), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("e8a41446-8a30-4c24-9f6e-ef65ea8157a9"), null, new DateTime(2024, 12, 26, 8, 24, 3, 246, DateTimeKind.Utc).AddTicks(9439), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "MesoCycle",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), "System", new DateTime(2024, 12, 26, 8, 24, 3, 258, DateTimeKind.Utc).AddTicks(5197), null, null, "Default Mesocycle" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 24, 3, 261, DateTimeKind.Utc).AddTicks(7607), new DateTime(2024, 12, 26, 8, 24, 3, 261, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "BodyPartId", "BodyWeightExercise", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4232), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4234), "Calves Two Second Pause" },
                    { new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4220), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4223), "Calves Four Second Eccentric" },
                    { new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4248), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4250), "Lying Dumbell Bicep Curl" },
                    { new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), true, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3881), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4184), "Reverse Nordics" },
                    { new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3868), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3870), "Cable Crunch" },
                    { new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3790), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3792), "Bench Press" },
                    { new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4198), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4200), "DualCableRow" },
                    { new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4205), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4208), "RDL" },
                    { new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4260), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4263), "Lying Overhead Triceps Extension" },
                    { new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4272), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(4275), "Single Arm Cable Lateral Raise" },
                    { new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3809), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3812), "Squat" },
                    { new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3822), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3825), "Deadlift" },
                    { new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3835), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3838), "Incline Dumbbell Press" },
                    { new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), false, null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3851), null, new DateTime(2024, 12, 26, 8, 24, 3, 242, DateTimeKind.Utc).AddTicks(3853), "Pull Down" }
                });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("e8a41446-8a30-4c24-9f6e-ef65ea8157a9"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("e8a41446-8a30-4c24-9f6e-ef65ea8157a9"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("f381e984-db01-46a4-8d03-6e502ddb908e"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "MicroCycle",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 1 });

            migrationBuilder.InsertData(
                table: "ExerciseDay",
                columns: new[] { "Id", "MicroCycleId", "MicroCycleMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 1 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 3 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 5 }
                });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("f381e984-db01-46a4-8d03-6e502ddb908e"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "ExerciseSet",
                columns: new[] { "ExerciseDayId", "ExerciseDayMicroCycleId", "ExerciseDayMicroCycleMesocycleId", "Id", "ExerciseId", "Reps", "TargetReps", "TargetWeight" },
                values: new object[,]
                {
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 1, new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0 },
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 2, new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0 },
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 3, new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 5.0 },
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 4, new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0 },
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 5, new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0 },
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 6, new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0 },
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 7, new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0 },
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 8, new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0 },
                    { 1, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 9, new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 10, new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 11, new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 46.5 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 12, new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 13, new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 41.5 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 14, new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 15, new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 16, new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 17, new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0 },
                    { 2, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 18, new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 19, new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 15, 16.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 20, new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 21, new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 22, new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 23, new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 24, new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 25, new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 26, new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0 },
                    { 3, 1, new Guid("60dd8edb-914f-46d8-a2cd-817b92838230"), 27, new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_BodyPartId",
                table: "Exercises",
                column: "BodyPartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "ExerciseSet");

            migrationBuilder.DropTable(
                name: "BodyParts");

            migrationBuilder.DropTable(
                name: "ExerciseDay");

            migrationBuilder.DropTable(
                name: "MicroCycle");

            migrationBuilder.DropTable(
                name: "MesoCycle");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("f381e984-db01-46a4-8d03-6e502ddb908e"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("e8a41446-8a30-4c24-9f6e-ef65ea8157a9"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("e8a41446-8a30-4c24-9f6e-ef65ea8157a9"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("e8a41446-8a30-4c24-9f6e-ef65ea8157a9"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("f381e984-db01-46a4-8d03-6e502ddb908e"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("f381e984-db01-46a4-8d03-6e502ddb908e"));

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
        }
    }
}
