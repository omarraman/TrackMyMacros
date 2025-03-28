﻿using System.ComponentModel.DataAnnotations;
using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

[CodeGen]
public class Exercise : Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public double WeightIncrease { get; set; }
    public int RepIncrease { get; set; }
    
    // public string VideoUrl { get; set; }
    public BodyPart BodyPart { get; set; }
    public Guid BodyPartId { get; set; }

    public bool BodyWeightExercise { get; set; }=false;

    private static Exercise Create(Guid id, string name, Guid bodyPartId, bool bodyWeightExercise = false, double weightIncrease = 0, int repIncrease = 0)
    {
        return new Exercise
        {
            Id = id,
            Name = name,
            BodyPartId = bodyPartId,
            BodyWeightExercise = bodyWeightExercise,
            WeightIncrease = weightIncrease,
            RepIncrease = repIncrease
        };
    }

    public static Exercise BenchPress()
    {
        return Create(new Guid("a0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Bench Press",
            Aggregates.Exercise.BodyPart.Chest().Id,false,.5
        );
    }
    
    public static Exercise Flyes()
    {
        return Create(new Guid("b0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Flyes",
            BodyPart.Chest().Id,false,.5
        );
    }
    
    public static Exercise Squat()
    {
        return Create(new Guid("c0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Squat",
            BodyPart.Quads().Id,false,1.25
        );
    }
    
    public static Exercise Deadlift()
    {
        return Create(new Guid("d0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Deadlift",
            BodyPart.Hamstrings().Id,false,1.25
        );
    }
    
    public static Exercise InclineDumbbellPress()
    {
        return Create(new Guid("e0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Incline Dumbbell Press",
            BodyPart.Chest().Id,false,.5
        );
    }
    
    public static Exercise PullDown()
    {
        return Create(new Guid("f0d4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Pull Down",
            BodyPart.Back().Id,false,1.25
        );
    }
    
    public static Exercise CalvesTwoSecondPause()
    {
        return Create(new Guid("a0a4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Calves Two Second Pause",
            BodyPart.Calves().Id,false,1
        );
    }
    
    public static Exercise CalvesFourSecondEccentric()
    {
        return Create(new Guid("a0b4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Calves Four Second Eccentric",
            BodyPart.Calves().Id,false,1
        );
    }
    
    public static Exercise LyingDumbellBicepCurl()
    {
        return Create(new Guid("a0c4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Lying Dumbell Bicep Curl",
               BodyPart.Biceps().Id,false,.25
        );
    }
    
    public static Exercise LyingOverheadTricepsExtension()
    {
        return Create(new Guid("a0e4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Lying Overhead Triceps Extension",
            BodyPart.Triceps().Id,false,.25
        );
    }
    
    public static Exercise SingleArmCableLateralRaise()
    {
        return Create(new Guid("a0f4c8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Single Arm Cable Lateral Raise",
            BodyPart.Shoulders().Id,false,.25
        );
    }
    
    public static Exercise ReverseNordics()
    {
        return Create(new Guid("a0d4a8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Reverse Nordics",
            BodyPart.Quads().Id,
            true,0,1
        );
    }
    
    public static Exercise CableCrunch()
    {
        return Create(new Guid("a0d4b8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "Cable Crunch",
            BodyPart.Abs().Id,false,.25
        );
    }
    
    public static Exercise DualCableRow()
    {
        return Create(new Guid("a0d4d8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "DualCableRow",
            BodyPart.Back().Id,false,1
        );
    }
    
    public static Exercise RDL()
    {
        return Create(new Guid("a0d4e8cd-e49a-49ca-88a5-2348fdc79f6d"),
            "RDL",
            new Guid("8d68c9e3-f8b3-4d17-9446-1e188a1a4744"),false,1.25
        );
    }

}

