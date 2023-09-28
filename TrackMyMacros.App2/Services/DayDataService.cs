using AutoMapper;
using Flurl.Http;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App2.Services;




public class DayDataService
{

        private readonly IMapper _mapper;

        public DayDataService( IMapper mapper) 
        {
            _mapper = mapper;
        }


        public async Task<DayViewModel> GetDay(DateOnly date )
        {

            try
            {
                // var uri =  "https://localhost:7115/api/Day?date=2023-09-26";
                var uri =  $"https://localhost:7115/api/Day?date={date.ToString("yyyy-MM-dd")}";

                var day2 = await uri
                    .GetStringAsync();
                var day = await uri
                    .GetJsonAsync<GetDayDto>();
                var dayViewModel = _mapper.Map<DayViewModel>(day);
            
                return dayViewModel;
            }
            catch (FlurlHttpException e)
            {
                Console.WriteLine("Bollox " + e);
                throw;  
            }
        }
        
        public async Task UpdateDay(DayViewModel dayViewModel )
        {

            try
            {
                var updateDpdateDayDto= _mapper.Map<UpdateDayDto>(dayViewModel);
                var uri =  "https://localhost:7115/api/Day";
                await uri
                    .PostJsonAsync(updateDpdateDayDto);
            
                
            }
            catch (FlurlHttpException e)
            {
                Console.WriteLine("Bollox " + e);
                throw;  
            }
        }
}