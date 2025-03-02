using TrackMyMacros.Application.Features.Week.Queries.GetList;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.Mesocycle.Queries.GetList
{
    public class GetMesocycleListQuery : RequestBase<IReadOnlyList<GetMesocycleDto>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetWeekListQuery> Weeks { get; set; }
        public int TotalWeeks { get; set; }
        public bool Complete { get; set; }
        public int CurrentWeekIndex { get; set; } = 1;
        public MyDayOfWeek CurrentDayOfWeek { get; set; } = MyDayOfWeek.Monday();
    }
}