using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

[CodeGen]
public class BodyPart:Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public SizeOfBodyPart Size { get; set; }
    
    public static BodyPart Chest()
    {
        return new BodyPart()
        {
            Id = new Guid("8D68C9E3-F8B3-4D17-9446-1E188A1A4744"),
            Name = "Chest",
            Size = SizeOfBodyPart.Two()
        };
        
    }
    
    public static BodyPart Back()
    {
        return new BodyPart()
        {
            Id = new Guid("6610bfab-7248-4b7b-94cd-b9fd5e38290d"),
            Name = "Back",
            Size = SizeOfBodyPart.Four()
        };
        
    }
    
    public static BodyPart Shoulders()
    {
        return new BodyPart()
        {
            Id = new Guid("5492de93-6f0b-443c-8f63-1eeb90b90c78"),
            Name = "Shoulders",
            Size = SizeOfBodyPart.One()            
        };
        
    }
    
    public static BodyPart Biceps()
    {
        return new BodyPart()
        {
            Id = new Guid("e4232daf-15cc-40f3-ba6f-d29dc7e9ad2a"),
            Name = "Biceps",
            Size = SizeOfBodyPart.One()
        };
        
    }
    
    public static BodyPart Triceps()
    {
        return new BodyPart()
        {
            Id = new Guid("6f639115-6ac7-48f9-8152-f08429bf7cd5"),
            Name = "Triceps",
            Size = SizeOfBodyPart.Three()
        };
        
    }
    
    public static BodyPart Forearms()
    {
        return new BodyPart()
        {
            Id = new Guid("18b68da4-f760-45cb-97c3-a216bf7f99b3"),
            Name = "Forearms",
            Size = SizeOfBodyPart.One()
                
        };
        
    }
    
    public static BodyPart Abs()
    {
        return new BodyPart()
        {
            Id = new Guid("ec1f33a5-91e5-4de9-9b74-e0fe7255f883"),
            Name = "Abs",
            Size = SizeOfBodyPart.Two()
        };
        
    }
    
    public static BodyPart Quads()
    {
        return new BodyPart()
        {
            Id = new Guid("f87d2a54-ba1a-4dbc-a900-25531fdbfbeb"),
            Name = "Quads",
            Size = SizeOfBodyPart.Four()
        };
        
    }
    
    public static BodyPart Hamstrings()
    {
        return new BodyPart()
        {
            Id = new Guid("6dd13251-7a07-423d-920c-46fae6d2cdcc"),
            Name = "Hamstrings",
            Size = SizeOfBodyPart.Four()
        };
        
    }
    
    public static BodyPart Glutes()
    {
        return new BodyPart()
        {
            Id = new Guid("d0d8ea0f-c077-42be-b31f-14ed90353455"),
            Name = "Glutes",
            Size = SizeOfBodyPart.Three()
        };
        
    }
    
    public static BodyPart Calves()
    {
        return new BodyPart()
        {
            Id = new Guid("2aa88079-b75d-417d-9eb2-6517fd2331c0"),
            Name = "Calves",
            Size = SizeOfBodyPart.Three()
        };
        
    }
    
    public static BodyPart Neck()
    {
        return new BodyPart()
        {
            Id = new Guid("ae834296-64ec-421a-ab40-d4a93dbbbe9f"),
            Name = "Neck",
            Size = SizeOfBodyPart.One()
        };
        
    }
    
    public static BodyPart Traps()
    {
        return new BodyPart()
        {
            Id = new Guid("d2be7249-479c-40e6-960e-ed906cd8c919"),
            Name = "Traps",
            Size = SizeOfBodyPart.Three()
        };
        
    }
    
    public static BodyPart Lats()
    {
        return new BodyPart()
        {
            Id = new Guid("c6f23e26-c20f-428e-95a7-6dbbe4de06fc"),
            Name = "Lats",
            Size = SizeOfBodyPart.Four()
        };
        
    }
    
    public static BodyPart LowerBack()
    {
        return new BodyPart()
        {
            Id = new Guid("fb70b309-fd97-4d65-8705-e4b4c490b653"),
            Name = "Lower Back",
            Size = SizeOfBodyPart.Three()
        };
        
    }
    
    public static BodyPart MiddleBack()
    {
        return new BodyPart()
        {
            Id = new Guid("8bdad449-6456-4ba2-b558-cb0a68fea5e7"),
            Name = "Middle Back"
        };
        
    }
    
    public static BodyPart GluteMedius()
    {
        return new BodyPart()
        {
            Id = new Guid("4cb86a7e-f5da-4101-9cfe-5cb8f293d438"),
            Name = "Glute Medius"
        };
        
    }

}