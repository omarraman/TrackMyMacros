using TrackMyMacros.Domain;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Persistance;

public class SeedData
{
    private static Guid _dayId=Guid.NewGuid();

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