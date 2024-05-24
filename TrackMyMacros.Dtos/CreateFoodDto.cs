﻿namespace TrackMyMacros.Dtos;

public class CreateFoodDto
{
    public string Name { get; set; }
    public double Carbohydrate { get; set; }
    public double Protein { get; set; }
    public double Fat { get; set; }

    public double Quantity { get; set; }
    public double DefaultQuantity { get; set; }
    public int UomId { get; set; }
}