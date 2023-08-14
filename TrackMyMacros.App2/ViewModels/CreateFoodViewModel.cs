using System.ComponentModel.DataAnnotations;

namespace TrackMyMacros.App2.ViewModels;

public class CreateFoodViewModel
{
    [Required]
    public string Name { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public double Carbohydrate { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public double Protein { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public double Fat { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public double Quantity { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Please select a unit of measure")]
    public int UomId { get; set; }
}