using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addsetgroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_Exercises_ExerciseId",
                table: "Set");

            migrationBuilder.DropForeignKey(
                name: "FK_Set_Workout_WorkoutWeekMesocycleId_WorkoutWeekId_WorkoutId",
                table: "Set");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Set",
                table: "Set");

            migrationBuilder.DropIndex(
                name: "IX_Set_ExerciseId",
                table: "Set");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("861277e3-ed0f-4707-9db7-8c277f227a1f"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("35942940-3fe5-47e8-adc7-7b34448dde62"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("35942940-3fe5-47e8-adc7-7b34448dde62"), 2 });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 1, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 2, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 3, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 4, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 5, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 6, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 7, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 8, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 9, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 10, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 11, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 12, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 13, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 14, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 15, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 16, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 17, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 18, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 19, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 20, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 21, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 22, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 23, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 24, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 25, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 26, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId" },
                keyColumnTypes: new[] { "integer", "integer", "integer", "uuid" },
                keyValues: new object[] { 27, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("35942940-3fe5-47e8-adc7-7b34448dde62"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("861277e3-ed0f-4707-9db7-8c277f227a1f"), 1 });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("861277e3-ed0f-4707-9db7-8c277f227a1f"));

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca") });

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"));

            migrationBuilder.DropColumn(
                name: "WorkoutWeekMesocycleId",
                table: "Set");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Set",
                newName: "SetGroupId");

            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "Set",
                newName: "SetGroupWorkoutWeekMesocycleId");

            migrationBuilder.RenameColumn(
                name: "WorkoutId",
                table: "Set",
                newName: "SetGroupWorkoutId");

            migrationBuilder.RenameColumn(
                name: "WorkoutWeekId",
                table: "Set",
                newName: "SetGroupWorkoutWeekId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Set",
                table: "Set",
                columns: new[] { "SetGroupWorkoutWeekMesocycleId", "SetGroupWorkoutWeekId", "SetGroupWorkoutId", "SetGroupId", "Id" });

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

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2473), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2212), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2427), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2379), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2435), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2399), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2407), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2463), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2453), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2486), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2390), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2418), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2444), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2495), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(5040), new DateTime(2025, 3, 17, 11, 25, 23, 671, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("d74b49cb-bbd4-4555-bd4d-f0360185a3ff"), 100, 100, 100, 10.0, new DateOnly(2025, 3, 17), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5684), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5668), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5701), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5612), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5593), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5487), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5635), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5650), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5722), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5742), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5443), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5515), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5531), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5547), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5572), new DateTime(2025, 3, 17, 11, 25, 23, 676, DateTimeKind.Utc).AddTicks(5576) });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("034dfed7-e842-4560-8c08-f06881ed69b4"), null, new DateTime(2025, 3, 17, 11, 25, 23, 679, DateTimeKind.Utc).AddTicks(9121), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "Complete", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name", "TotalWeeks" },
                values: new object[] { new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), false, "System", new DateTime(2025, 3, 17, 11, 25, 23, 695, DateTimeKind.Utc).AddTicks(486), 1, 1, null, null, "Default Mesocycle", 5 });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 25, 23, 701, DateTimeKind.Utc).AddTicks(9167), new DateTime(2025, 3, 17, 11, 25, 23, 701, DateTimeKind.Utc).AddTicks(9231) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("034dfed7-e842-4560-8c08-f06881ed69b4"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("034dfed7-e842-4560-8c08-f06881ed69b4"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("d74b49cb-bbd4-4555-bd4d-f0360185a3ff"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("d74b49cb-bbd4-4555-bd4d-f0360185a3ff"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1 },
                    { 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 3 },
                    { 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 5 }
                });

            migrationBuilder.InsertData(
                table: "SetGroup",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Priority" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1 },
                    { 2, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 2 },
                    { 3, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 3 },
                    { 4, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 4 },
                    { 5, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 5 },
                    { 6, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 6 },
                    { 7, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 7 },
                    { 8, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 8 },
                    { 9, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 9 },
                    { 10, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1 },
                    { 11, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 2 },
                    { 12, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 3 },
                    { 13, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 4 },
                    { 14, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 5 },
                    { 15, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 6 },
                    { 16, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 7 },
                    { 17, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 8 },
                    { 18, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 9 },
                    { 19, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1 },
                    { 20, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 2 },
                    { 21, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 3 },
                    { 22, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 4 },
                    { 23, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 5 },
                    { 24, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 6 },
                    { 25, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 7 },
                    { 26, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 8 },
                    { 27, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 9 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId", "Number", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 14, 21.0, 10.0 },
                    { 2, 2, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 12, 51.5, 10.0 },
                    { 3, 3, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 8, 52.5, 10.0 },
                    { 4, 4, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 11, 42.0, 10.0 },
                    { 5, 5, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 8, 9.0, 10.0 },
                    { 6, 6, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 8, 14.5, 10.0 },
                    { 7, 7, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 5, 100.0, 10.0 },
                    { 8, 8, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 7, 14.5, 10.0 },
                    { 9, 9, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 6, 14.5, 10.0 },
                    { 10, 10, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 14, 16.75, 16.75 },
                    { 11, 11, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 10, 24.5, 24.5 },
                    { 12, 12, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 9, 47.25, 47.25 },
                    { 13, 13, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 7, 47.25, 10.0 },
                    { 14, 14, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 8, 10.5, 10.5 },
                    { 15, 15, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 8, 14.75, 10.0 },
                    { 16, 16, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 5, 100.0, 10.0 },
                    { 17, 17, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 7, 14.75, 10.0 },
                    { 18, 18, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 6, 14.75, 10.0 },
                    { 19, 19, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 14, 16.75, 10.0 },
                    { 20, 20, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 14, 51.450000000000003, 10.0 },
                    { 21, 21, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 9, 47.25, 10.0 },
                    { 22, 22, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 10, 47.25, 10.0 },
                    { 23, 23, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 8, 10.5, 10.0 },
                    { 24, 24, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 10, 14.75, 10.0 },
                    { 25, 25, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 5, 100.0, 10.0 },
                    { 26, 26, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 7, 14.75, 10.0 },
                    { 27, 27, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"), 1, 0, 6, 14.75, 10.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SetGroup_ExerciseId",
                table: "SetGroup",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Set_SetGroup_SetGroupWorkoutWeekMesocycleId_SetGroupWorkout~",
                table: "Set",
                columns: new[] { "SetGroupWorkoutWeekMesocycleId", "SetGroupWorkoutWeekId", "SetGroupWorkoutId", "SetGroupId" },
                principalTable: "SetGroup",
                principalColumns: new[] { "WorkoutWeekMesocycleId", "WorkoutWeekId", "WorkoutId", "Id" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_SetGroup_SetGroupWorkoutWeekMesocycleId_SetGroupWorkout~",
                table: "Set");

            migrationBuilder.DropTable(
                name: "SetGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Set",
                table: "Set");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("d74b49cb-bbd4-4555-bd4d-f0360185a3ff"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("034dfed7-e842-4560-8c08-f06881ed69b4"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("034dfed7-e842-4560-8c08-f06881ed69b4"), 2 });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 1, 1, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 2, 2, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 3, 3, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 4, 4, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 5, 5, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 6, 6, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 7, 7, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 8, 8, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 9, 9, 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 10, 10, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 11, 11, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 12, 12, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 13, 13, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 14, 14, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 15, 15, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 16, 16, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 17, 17, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 18, 18, 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 19, 19, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 20, 20, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 21, 21, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 22, 22, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 23, 23, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 24, 24, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 25, 25, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 26, 26, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Set",
                keyColumns: new[] { "Id", "SetGroupId", "SetGroupWorkoutId", "SetGroupWorkoutWeekId", "SetGroupWorkoutWeekMesocycleId" },
                keyValues: new object[] { 27, 27, 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 1, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 2, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumns: new[] { "Id", "WeekId", "WeekMesocycleId" },
                keyValues: new object[] { 3, 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("034dfed7-e842-4560-8c08-f06881ed69b4"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("d74b49cb-bbd4-4555-bd4d-f0360185a3ff"), 1 });

            migrationBuilder.DeleteData(
                table: "Week",
                keyColumns: new[] { "Id", "MesocycleId" },
                keyValues: new object[] { 1, new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("d74b49cb-bbd4-4555-bd4d-f0360185a3ff"));

            migrationBuilder.DeleteData(
                table: "Mesocycles",
                keyColumn: "Id",
                keyValue: new Guid("19fa9dc9-cc12-47dc-8e34-d5b765a77aa4"));

            migrationBuilder.RenameColumn(
                name: "SetGroupId",
                table: "Set",
                newName: "Priority");

            migrationBuilder.RenameColumn(
                name: "SetGroupWorkoutId",
                table: "Set",
                newName: "WorkoutId");

            migrationBuilder.RenameColumn(
                name: "SetGroupWorkoutWeekId",
                table: "Set",
                newName: "WorkoutWeekId");

            migrationBuilder.RenameColumn(
                name: "SetGroupWorkoutWeekMesocycleId",
                table: "Set",
                newName: "ExerciseId");

            migrationBuilder.AddColumn<Guid>(
                name: "WorkoutWeekMesocycleId",
                table: "Set",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Set",
                table: "Set",
                columns: new[] { "WorkoutWeekMesocycleId", "WorkoutWeekId", "WorkoutId", "Id" });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2859), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2638), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2820), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2781), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2828), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2797), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2804), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2850), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2842), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2867), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2790), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2813), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2835), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2876), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(4945), new DateTime(2025, 3, 14, 17, 43, 34, 592, DateTimeKind.Utc).AddTicks(4983) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("861277e3-ed0f-4707-9db7-8c277f227a1f"), 100, 100, 100, 10.0, new DateOnly(2025, 3, 14), 10.0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8434), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8421), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8452), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8383), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8370), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8297), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8397), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8407), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8465), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8479), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8279), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8315), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8329), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8342), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8356), new DateTime(2025, 3, 14, 17, 43, 34, 595, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("35942940-3fe5-47e8-adc7-7b34448dde62"), null, new DateTime(2025, 3, 14, 17, 43, 34, 598, DateTimeKind.Utc).AddTicks(7163), null, null, "Test Food Combo" });

            migrationBuilder.InsertData(
                table: "Mesocycles",
                columns: new[] { "Id", "Complete", "CreatedBy", "CreatedDate", "CurrentDayOfWeek", "CurrentWeekIndex", "LastModifiedBy", "LastModifiedDate", "Name", "TotalWeeks" },
                values: new object[] { new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), false, "System", new DateTime(2025, 3, 14, 17, 43, 34, 607, DateTimeKind.Utc).AddTicks(6589), 1, 1, null, null, "Default Mesocycle", 5 });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 14, 17, 43, 34, 610, DateTimeKind.Utc).AddTicks(6577), new DateTime(2025, 3, 14, 17, 43, 34, 610, DateTimeKind.Utc).AddTicks(6616) });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("35942940-3fe5-47e8-adc7-7b34448dde62"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("35942940-3fe5-47e8-adc7-7b34448dde62"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("861277e3-ed0f-4707-9db7-8c277f227a1f"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "Id", "MesocycleId", "WeekIndex" },
                values: new object[] { 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), 1 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("861277e3-ed0f-4707-9db7-8c277f227a1f"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "WeekId", "WeekMesocycleId", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), 1 },
                    { 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), 3 },
                    { 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), 5 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "WorkoutId", "WorkoutWeekId", "WorkoutWeekMesocycleId", "ExerciseId", "Number", "Priority", "Reps", "TargetReps", "TargetWeight", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 1, 0, 14, 21.0, 10.0 },
                    { 2, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 2, 0, 12, 51.5, 10.0 },
                    { 3, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 3, 0, 8, 52.5, 10.0 },
                    { 4, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 4, 0, 11, 42.0, 10.0 },
                    { 5, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 5, 0, 8, 9.0, 10.0 },
                    { 6, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 6, 0, 8, 14.5, 10.0 },
                    { 7, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 7, 0, 5, 100.0, 10.0 },
                    { 8, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 8, 0, 7, 14.5, 10.0 },
                    { 9, 1, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 9, 0, 6, 14.5, 10.0 },
                    { 10, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 1, 0, 14, 16.75, 16.75 },
                    { 11, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 2, 0, 10, 24.5, 24.5 },
                    { 12, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 3, 0, 9, 47.25, 47.25 },
                    { 13, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 4, 0, 7, 47.25, 10.0 },
                    { 14, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 5, 0, 8, 10.5, 10.5 },
                    { 15, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 6, 0, 8, 14.75, 10.0 },
                    { 16, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 7, 0, 5, 100.0, 10.0 },
                    { 17, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 8, 0, 7, 14.75, 10.0 },
                    { 18, 2, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 9, 0, 6, 14.75, 10.0 },
                    { 19, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 1, 0, 14, 16.75, 10.0 },
                    { 20, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 2, 0, 14, 51.450000000000003, 10.0 },
                    { 21, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 3, 0, 9, 47.25, 10.0 },
                    { 22, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 4, 0, 10, 47.25, 10.0 },
                    { 23, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 5, 0, 8, 10.5, 10.0 },
                    { 24, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 6, 0, 10, 14.75, 10.0 },
                    { 25, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 7, 0, 5, 100.0, 10.0 },
                    { 26, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 8, 0, 7, 14.75, 10.0 },
                    { 27, 3, 1, new Guid("3d920482-be76-4e17-ad09-20413f88d2ca"), new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"), 1, 9, 0, 6, 14.75, 10.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Set_ExerciseId",
                table: "Set",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Set_Exercises_ExerciseId",
                table: "Set",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Set_Workout_WorkoutWeekMesocycleId_WorkoutWeekId_WorkoutId",
                table: "Set",
                columns: new[] { "WorkoutWeekMesocycleId", "WorkoutWeekId", "WorkoutId" },
                principalTable: "Workout",
                principalColumns: new[] { "WeekMesocycleId", "WeekId", "Id" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
