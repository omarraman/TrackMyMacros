using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Dtos.Exercise;

namespace TrackMyMacros.Application.Features.Exercise.Queries.GetList{
    public class GetExerciseListQuery : RequestBase<IReadOnlyList<GetExerciseDto>>
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