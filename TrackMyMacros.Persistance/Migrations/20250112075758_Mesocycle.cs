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
                name: "Mesocycles",
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
                    table.PrimaryKey("PK_Mesocycles", x => x.Id);
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
                name: "MesocycleWeek",
                columns: table => new
                {
                    MesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeekIndex = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MesocycleWeek", x => new { x.MesocycleId, x.Id });
                    table.ForeignKey(
                        name: "FK_MesocycleWeek_Mesocycles_MesocycleId",
                        column: x => x.MesocycleId,
                        principalTable: "Mesocycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MesocycleWeekDay",
                columns: table => new
                {
                    MesocycleWeekMesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    MesocycleWeekId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DayOfWeek = table.Column<int>(type: "integer", nullable: false),
                    Complete = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MesocycleWeekDay", x => new { x.MesocycleWeekMesocycleId, x.MesocycleWeekId, x.Id });
                    table.ForeignKey(
                        name: "FK_MesocycleWeekDay_MesocycleWeek_MesocycleWeekMesocycleId_Mes~",
                        columns: x => new { x.MesocycleWeekMesocycleId, x.MesocycleWeekId },
                        principalTable: "MesocycleWeek",
                        principalColumns: new[] { "MesocycleId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseDaySet",
                columns: table => new
                {
                    MesocycleWeekDayMesocycleWeekMesocycleId = table.Column<Guid>(type: "uuid", nullable: false),
                    MesocycleWeekDayMesocycleWeekId = table.Column<int>(type: "integer", nullable: false),
                    MesocycleWeekDayId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    TargetReps = table.Column<int>(type: "integer", nullable: false),
                    TargetWeight = table.Column<double>(type: "double precision", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseDaySet", x => new { x.MesocycleWeekDayMesocycleWeekMesocycleId, x.MesocycleWeekDayMesocycleWeekId, x.MesocycleWeekDayId, x.Id });
                    table.ForeignKey(
                        name: "FK_ExerciseDaySet_MesocycleWeekDay_MesocycleWeekDayMesocycleWe~",
                        columns: x => new { x.MesocycleWeekDayMesocycleWeekMesocycleId, x.MesocycleWeekDayMesocycleWeekId, x.MesocycleWeekDayId },
                        principalTable: "MesocycleWeekDay",
                        principalColumns: new[] { "MesocycleWeekMesocycleId", "MesocycleWeekId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BodyParts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name", "Size" },
                values: new object[,]
                {
                    { new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9017), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9021), "Forearms", 1.0 },
                    { new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8706), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8823), "Calves", 3.0 },
                    { new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8929), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8933), "Shoulders", 1.0 },
                    { new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8877), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8881), "Back", 4.0 },
                    { new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8940), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8943), "Hamstrings", 4.0 },
                    { new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8898), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8901), "Triceps", 3.0 },
                    { new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8908), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8911), "Chest", 2.0 },
                    { new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9008), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9011), "Neck", 1.0 },
                    { new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8998), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9002), "Glutes", 3.0 },
                    { new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9028), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9031), "Traps", 3.0 },
                    { new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8888), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8891), "Biceps", 1.0 },
                    { new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8920), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8924), "Abs", 2.0 },
                    { new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8950), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(8953), "Quads", 4.0 },
                    { new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9037), null, new DateTime(2025, 1, 12, 7, 57, 57, 822, DateTimeKind.Utc).AddTicks(9041), "Lower Back", 3.0 }
                });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 12, 7, 57, 57, 823, DateTimeKind.Utc).AddTicks(1949), new DateTime(2025, 1, 12, 7, 57, 57, 823, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("b77ca66e-b3bf-4bf6-af79-6ef199bb3c1b"), 100, 100, 100, 10.0, new DateOnly(2025, 1, 12), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("73150c63-5645-4d0a-abd6-e7657928117f"), null, new DateTime(2025, 1, 12, 7, 57, 57, 831, DateTimeKind.Utc).AddTicks(5819), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), "System", new DateTime(2025, 1, 12, 7, 57, 57, 844, DateTimeKind.Utc).AddTicks(709), null, null, "Default Mesocycle" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 12, 7, 57, 57, 851, DateTimeKind.Utc).AddTicks(61), new DateTime(2025, 1, 12, 7, 57, 57, 851, DateTimeKind.Utc).AddTicks(122) });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "BodyPartId", "BodyWeightExercise", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(90), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(93), "Calves Two Second Pause" },
                    { new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(74), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(77), "Calves Four Second Eccentric" },
                    { new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(106), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(109), "Lying Dumbell Bicep Curl" },
                    { new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), true, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(29), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(32), "Reverse Nordics" },
                    { new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(12), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(15), "Cable Crunch" },
                    { new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9906), null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9909), "Bench Press" },
                    { new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(46), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(49), "DualCableRow" },
                    { new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(54), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(58), "RDL" },
                    { new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(124), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(127), "Lying Overhead Triceps Extension" },
                    { new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(177), null, new DateTime(2025, 1, 12, 7, 57, 57, 828, DateTimeKind.Utc).AddTicks(180), "Single Arm Cable Lateral Raise" },
                    { new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9933), null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9936), "Squat" },
                    { new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9952), null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9955), "Deadlift" },
                    { new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9970), null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9973), "Incline Dumbbell Press" },
                    { new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"), false, null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9989), null, new DateTime(2025, 1, 12, 7, 57, 57, 827, DateTimeKind.Utc).AddTicks(9992), "Pull Down" }
                });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("73150c63-5645-4d0a-abd6-e7657928117f"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("73150c63-5645-4d0a-abd6-e7657928117f"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("b77ca66e-b3bf-4bf6-af79-6ef199bb3c1b"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "MesocycleWeek",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("b77ca66e-b3bf-4bf6-af79-6ef199bb3c1b"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "MesocycleWeekDay",
                columns: new[] { "Id", "MesocycleWeekId", "MesocycleWeekMesocycleId", "Complete", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), false, 1 },
                    { 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), false, 3 },
                    { 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), false, 5 }
                });

            migrationBuilder.InsertData(
                table: "ExerciseDaySet",
                columns: new[] { "Id", "MesocycleWeekDayId", "MesocycleWeekDayMesocycleWeekId", "MesocycleWeekDayMesocycleWeekMesocycleId", "ExerciseId", "Reps", "TargetReps", "TargetWeight" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0 },
                    { 2, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0 },
                    { 3, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 5.0 },
                    { 4, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0 },
                    { 5, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0 },
                    { 6, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0 },
                    { 7, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0 },
                    { 8, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0 },
                    { 9, 1, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0 },
                    { 10, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0 },
                    { 11, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 46.5 },
                    { 12, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0 },
                    { 13, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 41.5 },
                    { 14, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0 },
                    { 15, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0 },
                    { 16, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0 },
                    { 17, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0 },
                    { 18, 2, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0 },
                    { 19, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 15, 16.0 },
                    { 20, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0 },
                    { 21, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0 },
                    { 22, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0 },
                    { 23, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0 },
                    { 24, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0 },
                    { 25, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0 },
                    { 26, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0 },
                    { 27, 3, 1, new Guid("29913df7-6236-48c5-bb48-3d32fd1bb4d5"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0 }
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
                name: "ExerciseDaySet");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "MesocycleWeekDay");

            migrationBuilder.DropTable(
                name: "BodyParts");

            migrationBuilder.DropTable(
                name: "MesocycleWeek");

            migrationBuilder.DropTable(
                name: "Mesocycles");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("b77ca66e-b3bf-4bf6-af79-6ef199bb3c1b"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("73150c63-5645-4d0a-abd6-e7657928117f"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("73150c63-5645-4d0a-abd6-e7657928117f"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("73150c63-5645-4d0a-abd6-e7657928117f"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("b77ca66e-b3bf-4bf6-af79-6ef199bb3c1b"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b77ca66e-b3bf-4bf6-af79-6ef199bb3c1b"));

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
