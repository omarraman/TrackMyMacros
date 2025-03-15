using TrackMyMacros.Application.Features.Set.Queries.GetList;
using TrackMyMacros.Dtos.Workout;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.Workout.Queries.GetList
{
    public class GetWorkoutListQuery : RequestBase<IReadOnlyList<GetWorkoutDto>>
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public List<GetSetListQuery> Sets { get; init; }
    }
}