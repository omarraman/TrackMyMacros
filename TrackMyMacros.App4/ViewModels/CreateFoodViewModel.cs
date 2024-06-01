using System.ComponentModel.DataAnnotations;
using TrackMyMacros.App4.Attributes;

namespace TrackMyMacros.App4.ViewModels
{
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
        
        [CompareDefaultToMinToMaxQuantity]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public double DefaultQuantity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public double Min { get; set; }
        
        [CompareMinToMaxQuantity]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public double Max { get; set; }
        
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please select a unit of measure")]
        public int UomId { get; set; }
    }
}