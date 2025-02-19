using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddExerciseIdToSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("90b3e928-d572-487c-924c-b0cad99b5a53"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("b00befc1-4316-4caa-97c6-0485aefee809"), 1 });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b00befc1-4316-4caa-97c6-0485aefee809"));

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4") });

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("6ac3d10a-fa45-467b-8cff-61e54e08ffe4"));

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2920), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2508), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2800), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2679), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2809), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2702), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2711), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2910), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2850), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2929), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2692), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2791), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2818), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2940), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(5497), new DateTime(2025, 1, 25, 7, 11, 57, 958, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("34f12cfd-cc73-4851-82fd-a7a659cc7fc5"), 100, 100, 100, 10.0, new DateOnly(2025, 1, 25), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6249), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6200), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6274), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6152), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6135), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6031), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6168), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6178), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6393), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6411), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6005), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6056), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6091), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 1, 25, 7, 11, 57, 963, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("cc4e8f14-6aec-4b17-8fb6-605ccd425c2f"), null, new DateTime(2025, 1, 25, 7, 11, 57, 967, DateTimeKind.Utc).AddTicks(985), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), "System", new DateTime(2025, 1, 25, 7, 11, 57, 976, DateTimeKind.Utc).AddTicks(8256), 1, 1, null, null, "Default Mesocycle" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 25, 7, 11, 57, 982, DateTimeKind.Utc).AddTicks(3485), new DateTime(2025, 1, 25, 7, 11, 57, 982, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("cc4e8f14-6aec-4b17-8fb6-605ccd425c2f"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("cc4e8f14-6aec-4b17-8fb6-605ccd425c2f"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("34f12cfd-cc73-4851-82fd-a7a659cc7fc5"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("34f12cfd-cc73-4851-82fd-a7a659cc7fc5"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), 1 },
                    { 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), 3 },
                    { 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), 5 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10 },
                    { 2, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10 },
                    { 3, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 5.0, 10 },
                    { 4, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10 },
                    { 5, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 6, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 7, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 8, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 9, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 },
                    { 10, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10 },
                    { 11, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 46.5, 10 },
                    { 12, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10 },
                    { 13, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 41.5, 10 },
                    { 14, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 15, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 16, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 17, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 18, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 },
                    { 19, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 15, 16.0, 10 },
                    { 20, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10 },
                    { 21, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10 },
                    { 22, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10 },
                    { 23, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10 },
                    { 24, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10 },
                    { 25, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10 },
                    { 26, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10 },
                    { 27, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("34f12cfd-cc73-4851-82fd-a7a659cc7fc5"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("cc4e8f14-6aec-4b17-8fb6-605ccd425c2f"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("cc4e8f14-6aec-4b17-8fb6-605ccd425c2f"), 2 });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("cc4e8f14-6aec-4b17-8fb6-605ccd425c2f"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("34f12cfd-cc73-4851-82fd-a7a659cc7fc5"), 1 });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("34f12cfd-cc73-4851-82fd-a7a659cc7fc5"));

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d") });

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("eb62da5b-997e-4de9-bf61-3cd2756af90d"));

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2188), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(1939), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2118), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2080), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2125), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2096), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2104), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2139), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2196), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2089), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2112), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2131), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2204), new DateTime(2025, 1, 21, 18, 12, 54, 649, DateTimeKind.Utc).AddTicks(2206) });

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
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(791), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(778), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(734), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(720), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(642), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(749), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(763), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(820), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(865), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(624), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(657), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(672), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(689), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(705), new DateTime(2025, 1, 21, 18, 12, 54, 652, DateTimeKind.Utc).AddTicks(708) });

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
        }
    }
}
