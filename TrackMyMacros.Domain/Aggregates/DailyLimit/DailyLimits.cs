using Ardalis.GuardClauses;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.DailyLimit;

public class DailyLimits:Entity
{
    public Guid Id { get; set; }
    public int Calories { get; set; }
    public int Protein { get; set; }
    public int Fat { get; set; }
    public int Carbohydrate { get; set; }

    public DailyLimits(int calories, int protein, int fat, int carbohydrate)
    {
        
        if (calories!= protein*4 + fat*9 + carbohydrate*4)
        {
            throw new ArgumentException(nameof(calories), "Macronutrients do not add up to total calories");
        }
        
        Calories=Guard.Against.NegativeOrZero(calories, nameof(calories));
        Protein=Guard.Against.NegativeOrZero(protein, nameof(protein));
        Fat=Guard.Against.NegativeOrZero(fat, nameof(fat));
        Carbohydrate=Guard.Against.NegativeOrZero(carbohydrate, nameof(carbohydrate));

    }
}