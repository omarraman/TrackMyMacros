namespace TrackMyMacros.Dtos;

public class GetDayDto
{
    public DateOnly Date { get; set; }

    public List<GetMealDto> GetMealDtos { get; set; }
    
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
    
}

public class GetMealDto
{
    // public int Id { get; set; }
    
    public List<GetFoodAmountDto> FoodAmounts { get; set; } 
    
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
}

public class GetUomDto
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class GetFoodAmountDto
{
    public int FoodId { get; set; }
    public double Quantity { get; set; }
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
}

public class GetFoodDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double CarbohydrateAmount { get; set; }
    public double ProteinAmount { get; set; }
    public double FatAmount { get; set; }

    public double Quantity { get; set; }
    public int QuantityInGrams { get; set; }
    public int MeasurementUnit { get; set; }
    public double Calories { get; set; }

}