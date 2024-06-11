using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Domain.Aggregates.Recipe;

[CodeGen]
public class Recipe
{
    
    public Guid Id { get; set; }

    public string Name { get; set; }
    public List<RecipeFoodAmount> RecipeFoodAmounts { get; }= new();
    
}