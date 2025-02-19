using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddExNavPropToSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
