namespace TrackMyMacros.Dtos;

public class UpdateDailyLimitsDto
{
    public int Calories { get; set; }
    public double WeightInKg { get; set; }
    public int WeekdaysMealsPerDay { get; set; }
    public int     WeekendMealsPerDay { get; set; }

}