using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates;

namespace TrackMyMacros.Persistance;

public class SeedData
{
    private static Guid _dayId = Guid.NewGuid();

    public static IReadOnlyList<Food> Foods()
    {
        int id = 1;
        var foods = new List<Food>
        {
            new Food
            {
                Id = 1,
                Name = "Peanut Butter",
                CarbohydrateAmount = new CarbohydrateAmount(11),
                ProteinAmount = new ProteinAmount(20),
                FatAmount = new FatAmount(5),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 2,
                Name = "Hovis",
                CarbohydrateAmount = new CarbohydrateAmount(40),
                ProteinAmount = new ProteinAmount(10),
                FatAmount = new FatAmount(8),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 3,
                Name = "Apple",
                CarbohydrateAmount = new CarbohydrateAmount(14),
                ProteinAmount = new ProteinAmount(.3),
                FatAmount = new FatAmount(.3),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 4,
                Name = "Arrabiata Sauce Barilla",
                CarbohydrateAmount = new CarbohydrateAmount(5.5),
                ProteinAmount = new ProteinAmount(1.4),
                FatAmount = new FatAmount(3.1),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 5,
                Name = "Arla Kvarg Vanilj",
                CarbohydrateAmount = new CarbohydrateAmount(4),
                ProteinAmount = new ProteinAmount(9.7),
                FatAmount = new FatAmount(.2),
                Quantity = 100,
                QuantityInGrams = 100,
                DefaultQuantity = 40,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 6,
                Name = "Banana",
                CarbohydrateAmount = new CarbohydrateAmount(23),
                ProteinAmount = new ProteinAmount(1),
                FatAmount = new FatAmount(.1),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 7,
                Name = "Basmati Rice",
                CarbohydrateAmount = new CarbohydrateAmount(52),
                ProteinAmount = new ProteinAmount(5),
                FatAmount = new FatAmount(.1),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 8,
                Name = "Blueberries",
                CarbohydrateAmount = new CarbohydrateAmount(7.6),
                ProteinAmount = new ProteinAmount(.5),
                FatAmount = new FatAmount(.5),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 9,
                Name = "Bran Flakes",
                CarbohydrateAmount = new CarbohydrateAmount(65),
                ProteinAmount = new ProteinAmount(11),
                FatAmount = new FatAmount(2.2),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 10,
                Name = "Bread",
                CarbohydrateAmount = new CarbohydrateAmount(44),
                ProteinAmount = new ProteinAmount(10),
                FatAmount = new FatAmount(4),
                Quantity = 100,
                DefaultQuantity = 80,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 11,
                Name = "Breggott",
                CarbohydrateAmount = new CarbohydrateAmount(.4),
                ProteinAmount = new ProteinAmount(.4),
                FatAmount = new FatAmount(75),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 12,
                Name = "Bulgur",
                CarbohydrateAmount = new CarbohydrateAmount(76),
                ProteinAmount = new ProteinAmount(12),
                FatAmount = new FatAmount(1.3),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 13,
                Name = "Chicken Breast",
                CarbohydrateAmount = new CarbohydrateAmount(.1),
                ProteinAmount = new ProteinAmount(23),
                FatAmount = new FatAmount(.1),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 14,
                Name = "Chilli",
                CarbohydrateAmount = new CarbohydrateAmount(6.5),
                ProteinAmount = new ProteinAmount(7.8),
                FatAmount = new FatAmount(1.5),
                Quantity = 100,
                QuantityInGrams = 100,
                DefaultQuantity = 255,
                UomId = Uom.Grams.Id
            },

            new Food
            {
                Id = 15,
                Name = "Weetabix",
                CarbohydrateAmount = new CarbohydrateAmount(26),
                ProteinAmount = new ProteinAmount(4.5),
                FatAmount = new FatAmount(.8),
                Quantity = 100,
                DefaultQuantity = 40,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 16,
                Name = "Milk",
                CarbohydrateAmount = new CarbohydrateAmount(3.1),
                ProteinAmount = new ProteinAmount(3.3),
                FatAmount = new FatAmount(1.5),
                Quantity = 100,
                QuantityInGrams = 100,
                DefaultQuantity = 170,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 17,
                Name = "Raisins",
                CarbohydrateAmount = new CarbohydrateAmount(77),
                ProteinAmount = new ProteinAmount(2.5),
                FatAmount = new FatAmount(0.1),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 18,
                Name = "Philadelphia",
                CarbohydrateAmount = new CarbohydrateAmount(4.3),
                ProteinAmount = new ProteinAmount(5.4),
                FatAmount = new FatAmount(21),
                Quantity = 100,
                QuantityInGrams = 100,
                DefaultQuantity = 40,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 19,
                Name = "Huel",
                CarbohydrateAmount = new CarbohydrateAmount(38),
                ProteinAmount = new ProteinAmount(29),
                FatAmount = new FatAmount(113),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 20,
                Name = "Chicken Breast",
                CarbohydrateAmount = new CarbohydrateAmount(.1),
                ProteinAmount = new ProteinAmount(23),
                FatAmount = new FatAmount(.1),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 21,
                Name = "Bulgur Cooked",
                CarbohydrateAmount = new CarbohydrateAmount(28.84),
                ProteinAmount = new ProteinAmount(4.8),
                FatAmount = new FatAmount(0.4),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 22,
                Name = "Tortilla",
                CarbohydrateAmount = new CarbohydrateAmount(55),
                ProteinAmount = new ProteinAmount(8.3),
                FatAmount = new FatAmount(4.9),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 23,
                Name = "Oil",
                CarbohydrateAmount = new CarbohydrateAmount(0),
                ProteinAmount = new ProteinAmount(0),
                FatAmount = new FatAmount(100),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 24,
                Name = "Frozen Strawberries",
                CarbohydrateAmount = new CarbohydrateAmount(6.4),
                ProteinAmount = new ProteinAmount(.5),
                FatAmount = new FatAmount(.5),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 25,
                Name = "Granola",
                CarbohydrateAmount = new CarbohydrateAmount(50),
                ProteinAmount = new ProteinAmount(0.7),
                FatAmount = new FatAmount(15),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            new Food
            {
                Id = 26,
                Name = "Kilmeaden",
                CarbohydrateAmount = new CarbohydrateAmount(0.1),
                ProteinAmount = new ProteinAmount(25.5),
                FatAmount = new FatAmount(32),
                Quantity = 100,
                QuantityInGrams = 100,
                UomId = Uom.Grams.Id
            },
            // new Food
            // {
            //     Id = 14,
            //     Name = "Oil",
            //     CarbohydrateAmount = new CarbohydrateAmount(0),
            //     ProteinAmount = new ProteinAmount(0),
            //     FatAmount = new FatAmount(100),
            //     Quantity = 100,
            //     QuantityInGrams = 100,
            //     UomId = Uom.Grams.Id
            // },
        };
        return foods;
    }

    public static IReadOnlyList<Uom> Uoms()
    {
        int id = 1;
        var uoms = new List<Uom>
        {
            Uom.Grams,
        };
        return uoms;
    }

    /*public static IReadOnlyList<Day> Days()
    {
        return new List<Day>()
        {
            new Day
            {
                DayId = _dayId,
                Date1 = DateOnly.FromDateTime(DateTime.Now),
            }
        };

    }

    public static IReadOnlyList<Meal> Meals()
    {
        return new List<Meal>()
        {
            new Meal
            {
                DayId = _dayId,
                FoodAmounts = { new FoodAmount(1,10) ,new FoodAmount(2,20) },
            }
        };
    }*/
}