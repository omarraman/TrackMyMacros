using System.ComponentModel.DataAnnotations;
using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Attributes;

public class CompareDefaultToMinToMaxQuantityAttribute : ValidationAttribute
{
    public CompareDefaultToMinToMaxQuantityAttribute() { }

    public string GetErrorMessage() =>
        "Default must be between min and max quantity.";

    protected override ValidationResult? IsValid(
        object? value, ValidationContext validationContext)
    {
        var model = (CreateFoodViewModel)validationContext.ObjectInstance;
        var defaultQuantity = (double)value;

        if (defaultQuantity < model.Min)
            return new ValidationResult(GetErrorMessage());
        if (defaultQuantity > model.Max)
            return new ValidationResult(GetErrorMessage());

        
        return ValidationResult.Success;
    }
    
    
    
}