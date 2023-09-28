﻿namespace TrackMyMacros.Dtos;

public class FoodListItemDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double ProteinAmount { get; set; }
    public double CarbohydrateAmount { get; set; }
    public double FatAmount { get; set; }
    public double Quantity { get; set; }
    public string Uom { get; set; }
}