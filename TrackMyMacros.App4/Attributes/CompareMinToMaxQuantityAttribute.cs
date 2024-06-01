using System.ComponentModel.DataAnnotations;
using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Attributes;

public class CompareMinToMaxQuantityAttribute : ValidationAttribute
{
    public CompareMinToMaxQuantityAttribute() { }

    public string GetErrorMessage() =>
        "Max quantity must be less than to min quantity.";

    protected override ValidationResult? IsValid(
        object? value, ValidationContext validationContext)
    {
        var model = (CreateFoodViewModel)validationContext.ObjectInstance;
        var max = (double)value;

        if (max < model.Min)
        {
            return new ValidationResult(GetErrorMessage());
        }

        return ValidationResult.Success;
    }
    
    
    
}