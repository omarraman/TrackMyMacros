namespace TrackMyMacros.Dtos;

public class GetDailyLimitsDto
{
    // public Guid Id { get; set; }
    public int Calories { get; set; }
    public double WeightInKg { get; set; }
    public int WeekdaysMealsPerDay { get; set; }
    public int WeekendMealsPerDay { get; set; }
}