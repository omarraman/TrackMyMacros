using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.Dtos.Exercise{
    public class GetExerciseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double WeightIncrease { get; set; }
        public int RepIncrease { get; set; }
        // public string VideoUrl { get; set; }
        public BodyPart BodyPart { get; set; }
        public Guid BodyPartId { get; set; }
        public bool BodyWeightExercise { get; set; } = false;
    }
}