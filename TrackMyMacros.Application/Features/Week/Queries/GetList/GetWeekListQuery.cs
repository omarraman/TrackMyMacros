using TrackMyMacros.Application.Features.Workout.Queries.GetList;
using TrackMyMacros.Dtos.Week;

namespace TrackMyMacros.Application.Features.Week.Queries.GetList
{
    public class GetWeekListQuery : RequestBase<IReadOnlyList<GetWeekDto>>
    {
        public int WeekIndex { get; init; }
        public List<GetWorkoutListQuery> Workouts { get; init; }
    }
}