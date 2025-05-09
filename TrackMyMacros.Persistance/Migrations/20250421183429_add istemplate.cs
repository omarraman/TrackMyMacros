using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addistemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("71a5c095-c291-45c5-ae00-6182c998166e"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("37680512-b27f-4573-b890-610a9edf73b5"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("37680512-b27f-4573-b890-610a9edf73b5"), 2 });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 2, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 3, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 4, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 5, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 6, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 7, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 8, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 9, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 10, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 11, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 12, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 13, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 14, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 15, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 16, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 17, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 18, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 19, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 20, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 21, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 22, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 23, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 24, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 25, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 26, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 27, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("37680512-b27f-4573-b890-610a9edf73b5"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("71a5c095-c291-45c5-ae00-6182c998166e"), 1 });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "SetGroup",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("71a5c095-c291-45c5-ae00-6182c998166e"));

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2") });

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"));

            migrationBuilder.AddColumn<bool>(
                name: "IsTemplate",
                table: "Mesocycles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2171), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2063), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2148), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2125), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2153), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2134), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2139), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2167), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2163), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2175), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2129), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2144), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2158), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2179), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 4, 21, 18, 34, 29, 192, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("830f23d2-36eb-4242-b200-8ec698d4ab00"), 100, 100, 100, 10.0, new DateOnly(2025, 4, 21), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3027), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3020), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3035), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2998), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2990), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2943), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3006), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3011), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3043), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3051), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2927), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2953), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2961), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2970), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2981), new DateTime(2025, 4, 21, 18, 34, 29, 194, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("f8ebe4d1-e58b-4d7f-bd32-f0c89968fa34"), null, new DateTime(2025, 4, 21, 18, 34, 29, 196, DateTimeKind.Utc).AddTicks(647), null, null, "Test Food Combo" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 4, 21, 18, 34, 29, 207, DateTimeKind.Utc).AddTicks(1170), new DateTime(2025, 4, 21, 18, 34, 29, 207, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("f8ebe4d1-e58b-4d7f-bd32-f0c89968fa34"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("f8ebe4d1-e58b-4d7f-bd32-f0c89968fa34"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("830f23d2-36eb-4242-b200-8ec698d4ab00"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("830f23d2-36eb-4242-b200-8ec698d4ab00"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Mesocycles_Name",
                table: "Mesocycles",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mesocycles_Name",
                table: "Mesocycles");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("830f23d2-36eb-4242-b200-8ec698d4ab00"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("f8ebe4d1-e58b-4d7f-bd32-f0c89968fa34"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("f8ebe4d1-e58b-4d7f-bd32-f0c89968fa34"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("f8ebe4d1-e58b-4d7f-bd32-f0c89968fa34"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("830f23d2-36eb-4242-b200-8ec698d4ab00"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("830f23d2-36eb-4242-b200-8ec698d4ab00"));

            migrationBuilder.DropColumn(
                name: "IsTemplate",
                table: "Mesocycles");

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6738), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6616), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6679), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6715), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6691), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6696), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6733), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6727), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6743), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6685), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6704), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6722), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6748), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(8292), new DateTime(2025, 3, 17, 20, 51, 55, 852, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("71a5c095-c291-45c5-ae00-6182c998166e"), 100, 100, 100, 10.0, new DateOnly(2025, 3, 17), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1698), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1690), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1706), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1666), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1656), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1607), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1675), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1681), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1714), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1723), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1592), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1618), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1627), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1635), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1645), new DateTime(2025, 3, 17, 20, 51, 55, 855, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("37680512-b27f-4573-b890-610a9edf73b5"), null, new DateTime(2025, 3, 17, 20, 51, 55, 857, DateTimeKind.Utc).AddTicks(1655), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "Complete", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name", "TotalWeeks" },
                values: new object[] { new Guid("859679a6-1e25-4a53-9520-dad6e05db7c2"), false, "System", new DateTime(2025, 3, 17, 20, 51, 55, 864, DateTimeKind.Utc).AddTicks(5980), 1, 1, null, null, "Default Mesocycle", 5 });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 55, 866, DateTimeKind.Utc).AddTicks(9535), new DateTime(2025, 3, 17, 20, 51, 55, 866, DateTimeKind.Utc).AddTicks(9556) });

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
        }
    }
}
