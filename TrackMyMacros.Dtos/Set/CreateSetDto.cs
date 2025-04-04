namespace TrackMyMacros.Dtos.Set{
    public class CreateSetDto
    {
        public int Reps { get; init; }
        public double Weight { get; set; }
        public int TargetReps { get; set; }
        public double TargetWeight { get; set; }
        public int Number { get; set; }
    }
}