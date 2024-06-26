﻿namespace TrackMyMacros.App4.ViewModels
{
    public class FoodAmountViewModel
    {
        public int FoodId { get; set; }
        public double Quantity { get; set; }

        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
    
        public double Calories =>   (Protein * 4) + (Carbohydrate * 4) + (Fat * 9);  

    
        public void SetMacros(FoodListItemViewModel food)
        {
            if (food.Id==FoodId)
                return;
            FoodId= food.Id;

            if (food.Id==-1)
            {
                Protein= 0;
                Carbohydrate= 0;
                Fat= 0;
                return;
            }

            Quantity = food.DefaultQuantity??100;
            Protein=   (Quantity/100 * food.Protein);
            Carbohydrate= (Quantity/100 * food.Carbohydrate);
            Fat= (Quantity/100 * food.Fat);
        }

        public void SetQuantity(double quantity,FoodListItemViewModel food)
        {
            Quantity = quantity;

            Protein=   (Quantity/100 * food.Protein);
            Carbohydrate= (Quantity/100 * food.Carbohydrate);
            Fat= (Quantity/100 * food.Fat);
        }
    }
}