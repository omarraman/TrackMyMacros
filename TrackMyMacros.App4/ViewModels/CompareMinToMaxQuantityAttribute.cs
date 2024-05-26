using System.ComponentModel.DataAnnotations;

namespace TrackMyMacros.App4.ViewModels;

public class CompareMinToMaxQuantityAttribute : ValidationAttribute
{
    public CompareMinToMaxQuantityAttribute() { }

    public string GetErrorMessage() =>
        "Max quantity must be less than to min quantity.";

    protected override ValidationResult? IsValid(
        object? value, ValidationContext validationContext)
    {
        var mission = (CreateFoodViewModel)validationContext.ObjectInstance;
        var max = (int)value;

        if (max < mission.Min)
        {
            return new ValidationResult(GetErrorMessage());
        }

        return ValidationResult.Success;
    }
} 