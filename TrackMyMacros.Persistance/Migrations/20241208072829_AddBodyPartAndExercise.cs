oousing System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackMyMacros.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddBodyPartAndExercise : Migration
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
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    VideoUrl = table.Column<string>(type: "text", nullable: false),
                    BodyPartId = table.Column<Guid>(type: "uuid", nullable: false),
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

            migrationBuilder.InsertData(
                table: "BodyParts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4045f98f-21b0-4c61-8fd0-dd02a21547c4"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2997), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2998), "Quads" },
                    { new Guid("5b73818b-2c0f-43a5-aa15-02df756ab481"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(3000), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(3001), "Glutes" },
                    { new Guid("6a10d667-3bae-4473-905f-8edf3d235522"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2982), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2983), "Back" },
                    { new Guid("81d308c8-5ce7-44a5-b9c1-00c610e79b5c"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(3005), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(3007), "Neck" },
                    { new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2985), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2986), "Chest" },
                    { new Guid("9b32d4d5-b7a2-4aa3-8862-eef026938e49"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(3010), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(3012), "Abdominals" },
                    { new Guid("a44e98fc-a6a1-4955-9a4f-0d68ef89c4ba"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2978), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2979), "Triceps" },
                    { new Guid("b96f38fd-1105-474d-a578-6cb661d9b882"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2930), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2960), "Calves" },
                    { new Guid("d1fce414-03cb-4a93-a203-7a55a0a20d88"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2993), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2994), "Hamstrings" },
                    { new Guid("ff4fdfe9-9345-4152-85cf-58327a32af22"), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2989), null, new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(2990), "Shoulders" }
                });

            migrationBuilder.UpdateData(
                table: "DailyLimits",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(4052), new DateTime(2024, 12, 8, 7, 28, 29, 127, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Date", "Fat", "MealCount", "Protein" },
                values: new object[] { new Guid("b89c3992-3325-4467-b084-6daf5677d127"), 100, 100, 100, 10.0, new DateOnly(2024, 12, 8), 10.0, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("043cac74-577c-4fa5-8e09-00c05b31b463"), null, new DateTime(2024, 12, 8, 7, 28, 29, 132, DateTimeKind.Utc).AddTicks(8907), null, null, "Test Food Combo" });

            migrationBuilder.UpdateData(
                table: "Uoms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 8, 7, 28, 29, 135, DateTimeKind.Utc).AddTicks(9485), new DateTime(2024, 12, 8, 7, 28, 29, 135, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "BodyPartId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("11a34cfb-cabc-4dea-a0ef-f6e7803b2246"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3616), "Push-ups are a great bodyweight exercise for the upper body.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3617), "Bench Press", "https://www.youtube.com/watch?v=Eh00_rniF8E" },
                    { new Guid("2a7b2787-5e1f-4a5d-8d84-0aca46d6052c"), new Guid("4045f98f-21b0-4c61-8fd0-dd02a21547c4"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3630), "An essential exercise for building leg strength.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3631), "Squats", "https://www.youtube.com/watch?v=Dy28eq2PjcM" },
                    { new Guid("3c9d6d81-631f-4787-9135-3668f22cad6d"), new Guid("4045f98f-21b0-4c61-8fd0-dd02a21547c4"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3640), "An advanced exercise for building quad strength and mobility.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3641), "Reverse Nordics", "https://www.youtube.com/watch?v=hEZYIrEXA2M" },
                    { new Guid("4f517cbd-a107-4c9a-8b9e-647f5310c0bb"), new Guid("4045f98f-21b0-4c61-8fd0-dd02a21547c4"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3644), "Targets and isolates the quadriceps.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3645), "Sissy Squat", "https://www.youtube.com/watch?v=3B-3Khbht5E" },
                    { new Guid("54d2fd4e-4771-421d-ad4c-b9376b3aeed7"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3620), "Push-ups are a great bodyweight exercise for the upper body.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3622), "Flyes", "https://www.youtube.com/watch?v=Eh00_rniF8E" },
                    { new Guid("5aad75e5-feaa-45d0-a34b-c7f413c621fc"), new Guid("d1fce414-03cb-4a93-a203-7a55a0a20d88"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3650), "An essential exercise for the hamstrings and glutes.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3651), "Romanian Deadlift (RDL)", "https://www.youtube.com/watch?v=2SHsk9Azd4M" },
                    { new Guid("6bbe5654-2a23-4d19-b55a-d04024b18be3"), new Guid("b96f38fd-1105-474d-a578-6cb661d9b882"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3655), "A great exercise to target the calves.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3656), "Calf Raises", "https://www.youtube.com/watch?v=-M4-G8p8fmc" },
                    { new Guid("7c00631d-77e2-4108-9f39-a6d48735bb90"), new Guid("9b32d4d5-b7a2-4aa3-8862-eef026938e49"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3659), "A simple but effective core exercise.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3661), "Crunches", "https://www.youtube.com/watch?v=Xyd_fa5zoEU" },
                    { new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"), new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3584), "Push-ups are a great bodyweight exercise for the upper body.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3601), "Incline Dumbell Press", "https://www.youtube.com/watch?v=Eh00_rniF8E" },
                    { new Guid("c6d5a37c-6f19-40d5-93ae-0be9a6a9b8d3"), new Guid("6a10d667-3bae-4473-905f-8edf3d235522"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3625), "A machine exercise that targets the latissimus dorsi muscles.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3626), "Lat Pulldown", "https://www.youtube.com/watch?v=CAwf7n6Luuc" },
                    { new Guid("c7d8a457-41c5-4aa9-b47d-f33aa74d2772"), new Guid("6a10d667-3bae-4473-905f-8edf3d235522"), null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3635), "A great exercise to build a strong back.", null, new DateTime(2024, 12, 8, 7, 28, 29, 129, DateTimeKind.Utc).AddTicks(3636), "Rows", "https://www.youtube.com/watch?v=GZbfZ033f74" }
                });

            migrationBuilder.InsertData(
                table: "FoodComboAmount",
                columns: new[] { "FoodComboId", "Id", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[,]
                {
                    { new Guid("043cac74-577c-4fa5-8e09-00c05b31b463"), 1, 10.0, 10.0, 1, 10.0, 40.0 },
                    { new Guid("043cac74-577c-4fa5-8e09-00c05b31b463"), 2, 10.0, 10.0, 2, 10.0, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "DayId", "Id", "AllowedCarbohydrate", "AllowedFat", "AllowedProtein", "Carbohydrate", "Fat", "Protein" },
                values: new object[] { new Guid("b89c3992-3325-4467-b084-6daf5677d127"), 1, 10, 10, 10, 10.0, 10.0, 10.0 });

            migrationBuilder.InsertData(
                table: "FoodAmount",
                columns: new[] { "Id", "MealDayId", "MealId", "Carbohydrate", "Fat", "FoodId", "Protein", "Quantity" },
                values: new object[] { 1, new Guid("b89c3992-3325-4467-b084-6daf5677d127"), 1, 10.0, 10.0, 3, 10.0, 100.0 });

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
                name: "BodyParts");

            migrationBuilder.DeleteData(
                table: "FoodAmount",
                keyColumns: new[] { "Id", "MealDayId", "MealId" },
                keyValues: new object[] { 1, new Guid("b89c3992-3325-4467-b084-6daf5677d127"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("043cac74-577c-4fa5-8e09-00c05b31b463"), 1 });

            migrationBuilder.DeleteData(
                table: "FoodComboAmount",
                keyColumns: new[] { "FoodComboId", "Id" },
                keyValues: new object[] { new Guid("043cac74-577c-4fa5-8e09-00c05b31b463"), 2 });

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "Id",
                keyValue: new Guid("043cac74-577c-4fa5-8e09-00c05b31b463"));

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumns: new[] { "DayId", "Id" },
                keyValues: new object[] { new Guid("b89c3992-3325-4467-b084-6daf5677d127"), 1 });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b89c3992-3325-4467-b084-6daf5677d127"));

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
