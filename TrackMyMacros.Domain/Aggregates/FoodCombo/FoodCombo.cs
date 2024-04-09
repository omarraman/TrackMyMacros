using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Domain.Aggregates.FoodCombo;

[CodeGen]
public class FoodCombo:Entity
{
    private FoodCombo()
    {
        
    }
    public Guid Id { get; set; }

    public string Name { get; set; }
    public List<FoodComboAmount> FoodComboAmounts { get; } = new();
}

