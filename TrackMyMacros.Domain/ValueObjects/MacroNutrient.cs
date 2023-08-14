using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain;

public abstract class MacroNutrient : ValueObject<MacroNutrient>
{
    public abstract int CaloriesPerGram { get; }

    protected override bool EqualsCore(MacroNutrient other) => this.CaloriesPerGram == other.CaloriesPerGram;

    protected override int GetHashCodeCore()
    {
        return this.CaloriesPerGram.GetHashCode();
    }
}