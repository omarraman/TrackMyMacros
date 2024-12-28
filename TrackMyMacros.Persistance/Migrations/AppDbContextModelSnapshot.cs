﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TrackMyMacros.Persistance;

#nullable disable

namespace TrackMyMacros.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.DailyLimit.DailyLimits", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("Calories")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WeekdaysMealsPerDay")
                        .HasColumnType("integer");

                    b.Property<int>("WeekendMealsPerDay")
                        .HasColumnType("integer");

                    b.Property<double>("WeightInKg")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("DailyLimits", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000000"),
                            Calories = 2400,
                            CreatedDate = new DateTime(2024, 6, 17, 9, 48, 31, 802, DateTimeKind.Utc).AddTicks(2312),
                            LastModifiedDate = new DateTime(2024, 6, 17, 9, 48, 31, 802, DateTimeKind.Utc).AddTicks(2444),
                            WeekdaysMealsPerDay = 5,
                            WeekendMealsPerDay = 5,
                            WeightInKg = 75.900000000000006
                        });
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.Day.Day", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AllowedCarbohydrate")
                        .HasColumnType("integer");

                    b.Property<int>("AllowedFat")
                        .HasColumnType("integer");

                    b.Property<int>("AllowedProtein")
                        .HasColumnType("integer");

                    b.Property<double>("Carbohydrate")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<double>("Fat")
                        .HasColumnType("double precision");

                    b.Property<int>("MealCount")
                        .HasColumnType("integer");

                    b.Property<double>("Protein")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Days", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"),
                            AllowedCarbohydrate = 100,
                            AllowedFat = 100,
                            AllowedProtein = 100,
                            Carbohydrate = 10.0,
                            Date = new DateOnly(2024, 6, 17),
                            Fat = 10.0,
                            MealCount = 1,
                            Protein = 10.0
                        });
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("Id"), 100L, null, null, null, null, null);

                    b.Property<double>("CarbohydrateAmount")
                        .HasColumnType("double precision");

                    b.Property<double?>("DefaultQuantity")
                        .HasColumnType("double precision");

                    b.Property<double>("FatAmount")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("Guid")
                        .HasColumnType("uuid");

                    b.Property<double?>("Max")
                        .HasColumnType("double precision");

                    b.Property<double?>("Min")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("ProteinAmount")
                        .HasColumnType("double precision");

                    b.Property<double>("Quantity")
                        .HasColumnType("double precision");

                    b.Property<int>("QuantityInGrams")
                        .HasColumnType("integer");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<int>("UomId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Food", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarbohydrateAmount = 11.0,
                            FatAmount = 5.0,
                            Name = "Peanut Butter",
                            ProteinAmount = 20.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 2,
                            CarbohydrateAmount = 40.0,
                            FatAmount = 8.0,
                            Name = "Hovis",
                            ProteinAmount = 10.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 3,
                            CarbohydrateAmount = 14.0,
                            FatAmount = 0.29999999999999999,
                            Name = "Apple",
                            ProteinAmount = 0.29999999999999999,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 4,
                            CarbohydrateAmount = 5.5,
                            FatAmount = 3.1000000000000001,
                            Name = "Arrabiata Sauce Barilla",
                            ProteinAmount = 1.3999999999999999,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 5,
                            CarbohydrateAmount = 4.0,
                            DefaultQuantity = 40.0,
                            FatAmount = 0.20000000000000001,
                            Name = "Arla Kvarg Vanilj",
                            ProteinAmount = 9.6999999999999993,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 6,
                            CarbohydrateAmount = 23.0,
                            FatAmount = 0.10000000000000001,
                            Name = "Banana",
                            ProteinAmount = 1.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 7,
                            CarbohydrateAmount = 52.0,
                            FatAmount = 0.10000000000000001,
                            Name = "Basmati Rice",
                            ProteinAmount = 5.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 8,
                            CarbohydrateAmount = 7.5999999999999996,
                            FatAmount = 0.5,
                            Name = "Blueberries",
                            ProteinAmount = 0.5,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 9,
                            CarbohydrateAmount = 65.0,
                            FatAmount = 2.2000000000000002,
                            Name = "Bran Flakes",
                            ProteinAmount = 11.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 10,
                            CarbohydrateAmount = 44.0,
                            DefaultQuantity = 80.0,
                            FatAmount = 4.0,
                            Name = "Bread",
                            ProteinAmount = 10.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 11,
                            CarbohydrateAmount = 0.40000000000000002,
                            FatAmount = 75.0,
                            Name = "Breggott",
                            ProteinAmount = 0.40000000000000002,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 12,
                            CarbohydrateAmount = 76.0,
                            FatAmount = 1.3,
                            Name = "Bulgur",
                            ProteinAmount = 12.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 13,
                            CarbohydrateAmount = 0.10000000000000001,
                            FatAmount = 0.10000000000000001,
                            Name = "Chicken Breast",
                            ProteinAmount = 23.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 14,
                            CarbohydrateAmount = 6.5,
                            DefaultQuantity = 255.0,
                            FatAmount = 1.5,
                            Name = "Chilli",
                            ProteinAmount = 7.7999999999999998,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 15,
                            CarbohydrateAmount = 26.0,
                            DefaultQuantity = 40.0,
                            FatAmount = 0.80000000000000004,
                            Name = "Weetabix",
                            ProteinAmount = 4.5,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 16,
                            CarbohydrateAmount = 3.1000000000000001,
                            DefaultQuantity = 170.0,
                            FatAmount = 1.5,
                            Name = "Milk",
                            ProteinAmount = 3.2999999999999998,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 17,
                            CarbohydrateAmount = 77.0,
                            FatAmount = 0.10000000000000001,
                            Name = "Raisins",
                            ProteinAmount = 2.5,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 18,
                            CarbohydrateAmount = 4.2999999999999998,
                            DefaultQuantity = 40.0,
                            FatAmount = 21.0,
                            Name = "Philadelphia",
                            ProteinAmount = 5.4000000000000004,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 19,
                            CarbohydrateAmount = 38.0,
                            FatAmount = 113.0,
                            Name = "Huel",
                            ProteinAmount = 29.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 20,
                            CarbohydrateAmount = 0.10000000000000001,
                            FatAmount = 0.10000000000000001,
                            Name = "Chicken Breast",
                            ProteinAmount = 23.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 21,
                            CarbohydrateAmount = 28.84,
                            FatAmount = 0.40000000000000002,
                            Name = "Bulgur Cooked",
                            ProteinAmount = 4.7999999999999998,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 22,
                            CarbohydrateAmount = 55.0,
                            FatAmount = 4.9000000000000004,
                            Name = "Tortilla",
                            ProteinAmount = 8.3000000000000007,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 23,
                            CarbohydrateAmount = 0.0,
                            FatAmount = 100.0,
                            Name = "Oil",
                            ProteinAmount = 0.0,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 24,
                            CarbohydrateAmount = 6.4000000000000004,
                            FatAmount = 0.5,
                            Name = "Frozen Strawberries",
                            ProteinAmount = 0.5,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 25,
                            CarbohydrateAmount = 50.0,
                            FatAmount = 15.0,
                            Name = "Granola",
                            ProteinAmount = 0.69999999999999996,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        },
                        new
                        {
                            Id = 26,
                            CarbohydrateAmount = 0.10000000000000001,
                            FatAmount = 32.0,
                            Name = "Kilmeaden",
                            ProteinAmount = 25.5,
                            Quantity = 100.0,
                            QuantityInGrams = 100,
                            RecipeId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UomId = 1
                        });
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.FoodCombo.FoodCombo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FoodCombos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"),
                            CreatedDate = new DateTime(2024, 6, 17, 9, 48, 31, 813, DateTimeKind.Utc).AddTicks(1924),
                            Name = "Test Food Combo"
                        });
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.Recipe.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Recipes", (string)null);
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.WeightReading.WeightReading", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("WeightReadings", (string)null);
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Uom", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Uoms", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 17, 9, 48, 31, 818, DateTimeKind.Utc).AddTicks(921),
                            LastModifiedDate = new DateTime(2024, 6, 17, 9, 48, 31, 818, DateTimeKind.Utc).AddTicks(971),
                            Name = "Grams"
                        });
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.Day.Day", b =>
                {
                    b.OwnsMany("TrackMyMacros.Domain.Aggregates.Day.Day.Meals#TrackMyMacros.Domain.ValueObjects.Meal", "Meals", b1 =>
                        {
                            b1.Property<Guid>("DayId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<int>("AllowedCarbohydrate")
                                .HasColumnType("integer");

                            b1.Property<int>("AllowedFat")
                                .HasColumnType("integer");

                            b1.Property<int>("AllowedProtein")
                                .HasColumnType("integer");

                            b1.Property<double>("Carbohydrate")
                                .HasColumnType("double precision");

                            b1.Property<double>("Fat")
                                .HasColumnType("double precision");

                            b1.Property<double>("Protein")
                                .HasColumnType("double precision");

                            b1.HasKey("DayId", "Id");

                            b1.ToTable("Meal", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("DayId");

                            b1.OwnsMany("TrackMyMacros.Domain.Aggregates.Day.Day.Meals#TrackMyMacros.Domain.ValueObjects.Meal.FoodAmounts#TrackMyMacros.Domain.ValueObjects.FoodAmount", "FoodAmounts", b2 =>
                                {
                                    b2.Property<Guid>("MealDayId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("MealId")
                                        .HasColumnType("integer");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b2.Property<int>("Id"));

                                    b2.Property<double>("Carbohydrate")
                                        .HasColumnType("double precision");

                                    b2.Property<double>("Fat")
                                        .HasColumnType("double precision");

                                    b2.Property<int>("FoodId")
                                        .HasColumnType("integer");

                                    b2.Property<double>("Protein")
                                        .HasColumnType("double precision");

                                    b2.Property<double>("Quantity")
                                        .HasColumnType("double precision");

                                    b2.HasKey("MealDayId", "MealId", "Id");

                                    b2.ToTable("FoodAmount", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("MealDayId", "MealId");

                                    b2.HasData(
                                        new
                                        {
                                            MealDayId = new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"),
                                            MealId = 1,
                                            Id = 1,
                                            Carbohydrate = 10.0,
                                            Fat = 10.0,
                                            FoodId = 3,
                                            Protein = 10.0,
                                            Quantity = 100.0
                                        });
                                });

                            b1.Navigation("FoodAmounts");

                            b1.HasData(
                                new
                                {
                                    DayId = new Guid("30f58b50-de2d-454a-9a3e-8ea085d5cd24"),
                                    Id = 1,
                                    AllowedCarbohydrate = 10,
                                    AllowedFat = 10,
                                    AllowedProtein = 10,
                                    Carbohydrate = 10.0,
                                    Fat = 10.0,
                                    Protein = 10.0
                                });
                        });

                    b.Navigation("Meals");
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.FoodCombo.FoodCombo", b =>
                {
                    b.OwnsMany("TrackMyMacros.Domain.Aggregates.FoodCombo.FoodCombo.FoodComboAmounts#TrackMyMacros.Domain.ValueObjects.FoodComboAmount", "FoodComboAmounts", b1 =>
                        {
                            b1.Property<Guid>("FoodComboId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<double>("Carbohydrate")
                                .HasColumnType("double precision");

                            b1.Property<double>("Fat")
                                .HasColumnType("double precision");

                            b1.Property<int>("FoodId")
                                .HasColumnType("integer");

                            b1.Property<double>("Protein")
                                .HasColumnType("double precision");

                            b1.Property<double>("Quantity")
                                .HasColumnType("double precision");

                            b1.HasKey("FoodComboId", "Id");

                            b1.ToTable("FoodComboAmount", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("FoodComboId");

                            b1.HasData(
                                new
                                {
                                    FoodComboId = new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"),
                                    Id = 1,
                                    Carbohydrate = 10.0,
                                    Fat = 10.0,
                                    FoodId = 1,
                                    Protein = 10.0,
                                    Quantity = 40.0
                                },
                                new
                                {
                                    FoodComboId = new Guid("ad21a88d-35cc-40c5-9d69-c3d50fbadefd"),
                                    Id = 2,
                                    Carbohydrate = 10.0,
                                    Fat = 10.0,
                                    FoodId = 2,
                                    Protein = 10.0,
                                    Quantity = 200.0
                                });
                        });

                    b.Navigation("FoodComboAmounts");
                });

            modelBuilder.Entity("TrackMyMacros.Domain.Aggregates.Recipe.Recipe", b =>
                {
                    b.OwnsMany("TrackMyMacros.Domain.Aggregates.Recipe.Recipe.RecipeFoodAmounts#TrackMyMacros.Domain.ValueObjects.RecipeFoodAmount", "RecipeFoodAmounts", b1 =>
                        {
                            b1.Property<Guid>("RecipeId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<double>("Carbohydrate")
                                .HasColumnType("double precision");

                            b1.Property<double>("Fat")
                                .HasColumnType("double precision");

                            b1.Property<int>("FoodId")
                                .HasColumnType("integer");

                            b1.Property<double>("Protein")
                                .HasColumnType("double precision");

                            b1.Property<double>("Quantity")
                                .HasColumnType("double precision");

                            b1.HasKey("RecipeId", "Id");

                            b1.ToTable("RecipeFoodAmount", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("RecipeId");
                        });

                    b.Navigation("RecipeFoodAmounts");
                });
#pragma warning restore 612, 618
        }
    }
}
