using Ardalis.GuardClauses;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain;

// public class Uom
// {
//     private int _numericEquivalent;
//
//     public Uom(int numericEquivalent)
//     {
//         _numericEquivalent = numericEquivalent;
//     }
//
//     public static  Uom  Grams => new Uom(1);
//     public static  Uom  Ml => new Uom(2);
//     public static  Uom  Bars => new Uom(2);
// }
//     


public class Uom:Entity
{
    
    public static  Uom Grams => new Uom(1,"Grams");

    public static Uom Create(int id)
    {
        switch (id)
        {
            case 1:
                return Grams;
            default:
                throw new Exception("Invalid Uom Id");
        }
        
    }
    private Uom(int id, string name)
    {
        Guard.Against.NegativeOrZero(id, nameof(id));
        Guard.Against.NullOrEmpty(name, nameof(name));
        Id = id;
        Name = name;
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
}