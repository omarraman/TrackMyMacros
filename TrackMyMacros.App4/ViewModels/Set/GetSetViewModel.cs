namespace TrackMyMacros.App4.ViewModels.Set
{
    public class GetSetViewModel
    {
        // public Set(int reps, int targetReps, double targetWeight, Guid exerciseId)
        // {
        //     Reps = reps;
        //     TargetReps = targetReps;
        //     TargetWeight = targetWeight;
        //     ExerciseId = exerciseId;
        // }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public int TargetReps { get; set; }
        public double TargetWeight { get; set; }
        public int Number { get; set; }
        
        public GetSetViewModel Clone()
        {
            return new GetSetViewModel
            {
                Reps = Reps,
                Weight = Weight,
                TargetReps = TargetReps,
                TargetWeight = TargetWeight,
                Number = Number
            };
        }

        public GetSetViewModel AddFollowingSet()
        {
            var newSet = Clone();
            newSet.Number++;
            return newSet;
        }
    }
}