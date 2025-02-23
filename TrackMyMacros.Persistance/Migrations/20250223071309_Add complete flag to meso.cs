using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addcompleteflagtomeso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("d033f1b8-e536-4775-bb1a-9389962a26d8"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("f300de70-7b2f-45de-a9e2-937540ff0ce9"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("f300de70-7b2f-45de-a9e2-937540ff0ce9"), 2 });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("f300de70-7b2f-45de-a9e2-937540ff0ce9"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("d033f1b8-e536-4775-bb1a-9389962a26d8"), 1 });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("d033f1b8-e536-4775-bb1a-9389962a26d8"));

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd") });

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"));

            migrationBuilder.AddColumn<bool>(
                name: "Complete",
                table: "Mesocycles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalWeeks",
                table: "Mesocycles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2616), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2368), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2583), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2503), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2591), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2561), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2569), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2610), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2604), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2624), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2551), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2577), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2597), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2630), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(4480), new DateTime(2025, 2, 23, 7, 13, 8, 968, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("4bfacdcb-7b32-4041-bf60-a33d03f5a588"), 100, 100, 100, 10.0, new DateOnly(2025, 2, 23), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2969), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2885), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2987), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2803), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2788), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2693), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2818), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2867), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(3004), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(3020), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2667), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2714), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2732), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2748), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2769), new DateTime(2025, 2, 23, 7, 13, 8, 972, DateTimeKind.Utc).AddTicks(2772) });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("a900e708-507a-4950-8edc-99d80560906c"), null, new DateTime(2025, 2, 23, 7, 13, 8, 976, DateTimeKind.Utc).AddTicks(1697), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "Complete", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name", "TotalWeeks" },
                values: new object[] { new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), false, "System", new DateTime(2025, 2, 23, 7, 13, 8, 983, DateTimeKind.Utc).AddTicks(1340), 1, 1, null, null, "Default Mesocycle", 5 });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 23, 7, 13, 8, 987, DateTimeKind.Utc).AddTicks(5261), new DateTime(2025, 2, 23, 7, 13, 8, 987, DateTimeKind.Utc).AddTicks(5317) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("a900e708-507a-4950-8edc-99d80560906c"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("a900e708-507a-4950-8edc-99d80560906c"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("4bfacdcb-7b32-4041-bf60-a33d03f5a588"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("4bfacdcb-7b32-4041-bf60-a33d03f5a588"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), 1 },
                    { 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), 3 },
                    { 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), 5 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10.0 },
                    { 2, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10.0 },
                    { 3, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 5.0, 10.0 },
                    { 4, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10.0 },
                    { 5, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 6, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 7, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 8, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 9, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 },
                    { 10, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10.0 },
                    { 11, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 46.5, 10.0 },
                    { 12, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10.0 },
                    { 13, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 41.5, 10.0 },
                    { 14, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 15, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 16, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 17, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 18, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 },
                    { 19, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 15, 16.0, 10.0 },
                    { 20, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10.0 },
                    { 21, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10.0 },
                    { 22, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10.0 },
                    { 23, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 24, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 25, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 26, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 27, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("4bfacdcb-7b32-4041-bf60-a33d03f5a588"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("a900e708-507a-4950-8edc-99d80560906c"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("a900e708-507a-4950-8edc-99d80560906c"), 2 });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("a900e708-507a-4950-8edc-99d80560906c"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("4bfacdcb-7b32-4041-bf60-a33d03f5a588"), 1 });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("4bfacdcb-7b32-4041-bf60-a33d03f5a588"));

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47") });

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("f53e551b-3a63-4421-974f-bc8d03cd6d47"));

            migrationBuilder.DropColumn(
                name: "Complete",
                table: "Mesocycles");

            migrationBuilder.DropColumn(
                name: "TotalWeeks",
                table: "Mesocycles");

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7149), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(6940), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7079), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7123), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7095), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7101), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7143), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7136), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7154), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7088), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7110), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7129), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7161), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 2, 18, 18, 44, 0, 462, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("d033f1b8-e536-4775-bb1a-9389962a26d8"), 100, 100, 100, 10.0, new DateOnly(2025, 2, 18), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6118), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6107), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6130), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6072), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6059), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(5991), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6085), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6092), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6143), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6154), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(5971), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6007), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6020), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6032), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6046), new DateTime(2025, 2, 18, 18, 44, 0, 466, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("f300de70-7b2f-45de-a9e2-937540ff0ce9"), null, new DateTime(2025, 2, 18, 18, 44, 0, 470, DateTimeKind.Utc).AddTicks(7021), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), "System", new DateTime(2025, 2, 18, 18, 44, 0, 479, DateTimeKind.Utc).AddTicks(867), 1, 1, null, null, "Default Mesocycle" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 44, 0, 482, DateTimeKind.Utc).AddTicks(1706), new DateTime(2025, 2, 18, 18, 44, 0, 482, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("f300de70-7b2f-45de-a9e2-937540ff0ce9"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("f300de70-7b2f-45de-a9e2-937540ff0ce9"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("d033f1b8-e536-4775-bb1a-9389962a26d8"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("d033f1b8-e536-4775-bb1a-9389962a26d8"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), 1 },
                    { 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), 3 },
                    { 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), 5 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10.0 },
                    { 2, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10.0 },
                    { 3, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 5.0, 10.0 },
                    { 4, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10.0 },
                    { 5, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 6, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 7, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 8, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 9, 1, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 },
                    { 10, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 14, 20.0, 10.0 },
                    { 11, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 46.5, 10.0 },
                    { 12, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10.0 },
                    { 13, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 41.5, 10.0 },
                    { 14, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 15, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 16, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 17, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 18, 2, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 },
                    { 19, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 15, 16.0, 10.0 },
                    { 20, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 12, 49.0, 10.0 },
                    { 21, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 9, 45.0, 10.0 },
                    { 22, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 40.0, 10.0 },
                    { 23, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 8, 9.0, 10.0 },
                    { 24, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 10, 17.0, 10.0 },
                    { 25, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 3, 100.0, 10.0 },
                    { 26, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 7, 15.0, 10.0 },
                    { 27, 3, 1, new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 0, 5, 10.0, 10.0 }
                });
        }
    }
}
