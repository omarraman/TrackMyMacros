using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addincrementtoexercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("6c944dee-d825-4b52-800a-d47de308bd7b"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("1341d11a-608e-4147-b1a5-4683884c66d4"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("1341d11a-608e-4147-b1a5-4683884c66d4"), 2 });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("1341d11a-608e-4147-b1a5-4683884c66d4"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("6c944dee-d825-4b52-800a-d47de308bd7b"), 1 });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("6c944dee-d825-4b52-800a-d47de308bd7b"));

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4") });

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"));

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Set",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "RepIncrease",
                table: "Exercises",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "WeightIncrease",
                table: "Exercises",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7645), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7438), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7611), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7573), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7618), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7589), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7596), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7638), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7632), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7651), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7582), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7624), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7660), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(9480), new DateTime(2025, 2, 9, 16, 47, 32, 355, DateTimeKind.Utc).AddTicks(9511) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("8edc9e0f-838c-4ec8-8a00-76d73a068533"), 100, 100, 100, 10.0, new DateOnly(2025, 2, 9), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5762), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5765), 0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5749), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5751), 0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5777), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5780), 0, 0.25 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5709), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5712), 1, 0.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5696), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5698), 0, 0.25 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5618), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5621), 0, 0.5 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5723), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5726), 0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5732), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5735), 0, 1.25 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5792), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5795), 0, 0.25 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5806), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5809), 0, 0.25 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5600), 0, 0.5 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5635), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5638), 0, 1.25 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5652), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5654), 0, 1.25 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5665), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5668), 0, 0.5 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate", "RepIncrease", "WeightIncrease" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5681), new DateTime(2025, 2, 9, 16, 47, 32, 359, DateTimeKind.Utc).AddTicks(5683), 0, 1.25 });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("834a8f00-2837-4c9e-b95e-15e33c55f3cc"), null, new DateTime(2025, 2, 9, 16, 47, 32, 362, DateTimeKind.Utc).AddTicks(4215), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), "System", new DateTime(2025, 2, 9, 16, 47, 32, 368, DateTimeKind.Utc).AddTicks(9724), 1, 1, null, null, "Default Mesocycle" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 47, 32, 371, DateTimeKind.Utc).AddTicks(3361), new DateTime(2025, 2, 9, 16, 47, 32, 371, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("834a8f00-2837-4c9e-b95e-15e33c55f3cc"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("834a8f00-2837-4c9e-b95e-15e33c55f3cc"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("8edc9e0f-838c-4ec8-8a00-76d73a068533"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("8edc9e0f-838c-4ec8-8a00-76d73a068533"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), 1 },
                    { 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), 3 },
                    { 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), 5 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10.0 },
                    { 2, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10.0 },
                    { 3, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 5.0, 10.0 },
                    { 4, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10.0 },
                    { 5, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 6, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 7, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 8, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 9, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 },
                    { 10, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10.0 },
                    { 11, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 46.5, 10.0 },
                    { 12, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10.0 },
                    { 13, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 41.5, 10.0 },
                    { 14, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 15, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 16, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 17, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 18, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 },
                    { 19, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 15, 16.0, 10.0 },
                    { 20, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10.0 },
                    { 21, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10.0 },
                    { 22, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10.0 },
                    { 23, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 24, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 25, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 26, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 27, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("8edc9e0f-838c-4ec8-8a00-76d73a068533"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("834a8f00-2837-4c9e-b95e-15e33c55f3cc"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("834a8f00-2837-4c9e-b95e-15e33c55f3cc"), 2 });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("834a8f00-2837-4c9e-b95e-15e33c55f3cc"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("8edc9e0f-838c-4ec8-8a00-76d73a068533"), 1 });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("8edc9e0f-838c-4ec8-8a00-76d73a068533"));

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("d965d912-6fad-436b-af1e-0daeaed93421") });

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("d965d912-6fad-436b-af1e-0daeaed93421"));

            migrationBuilder.DropColumn(
                name: "RepIncrease",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "WeightIncrease",
                table: "Exercises");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Set",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9294), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9031), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9247), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9199), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9256), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9219), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9228), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9284), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9275), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9305), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9210), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9239), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9265), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9314), new DateTime(2025, 1, 25, 7, 26, 42, 345, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 346, DateTimeKind.Utc).AddTicks(2145), new DateTime(2025, 1, 25, 7, 26, 42, 346, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("6c944dee-d825-4b52-800a-d47de308bd7b"), 100, 100, 100, 10.0, new DateOnly(2025, 1, 25), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9979), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9962), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9997), new DateTime(2025, 1, 25, 7, 26, 42, 351, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9917), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9901), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9808), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9934), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9944), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 351, DateTimeKind.Utc).AddTicks(18), new DateTime(2025, 1, 25, 7, 26, 42, 351, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 351, DateTimeKind.Utc).AddTicks(36), new DateTime(2025, 1, 25, 7, 26, 42, 351, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9786), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9828), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9847), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9883), new DateTime(2025, 1, 25, 7, 26, 42, 350, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("1341d11a-608e-4147-b1a5-4683884c66d4"), null, new DateTime(2025, 1, 25, 7, 26, 42, 354, DateTimeKind.Utc).AddTicks(2740), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), "System", new DateTime(2025, 1, 25, 7, 26, 42, 364, DateTimeKind.Utc).AddTicks(9150), 1, 1, null, null, "Default Mesocycle" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 26, 42, 369, DateTimeKind.Utc).AddTicks(1132), new DateTime(2025, 1, 25, 7, 26, 42, 369, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1341d11a-608e-4147-b1a5-4683884c66d4"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("1341d11a-608e-4147-b1a5-4683884c66d4"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("6c944dee-d825-4b52-800a-d47de308bd7b"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("6c944dee-d825-4b52-800a-d47de308bd7b"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), 1 },
                    { 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), 3 },
                    { 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), 5 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10 },
                    { 2, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10 },
                    { 3, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 5.0, 10 },
                    { 4, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10 },
                    { 5, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 6, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 7, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 8, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 9, 1, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 },
                    { 10, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10 },
                    { 11, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 46.5, 10 },
                    { 12, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10 },
                    { 13, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 41.5, 10 },
                    { 14, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 15, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 16, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 17, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 18, 2, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 },
                    { 19, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 15, 16.0, 10 },
                    { 20, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10 },
                    { 21, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10 },
                    { 22, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10 },
                    { 23, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 24, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 25, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 26, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 27, 3, 1, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 }
                });
        }
    }
}
