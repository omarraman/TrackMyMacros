using AutoMapper;
using TrackMyMacros.Dtos;
using System.Net;
using Flurl.Http;
using Microsoft.Extensions.Options;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App4.Services
{
    public class MesocycleDataService : IMesocycleDataService
    {
        private IMapper _mapper;
        private string _baseUrl;
        public MesocycleDataService(IMapper mapper, string? baseUrl)
        {
            _baseUrl = baseUrl;
            _mapper = mapper;
        }

        public async Task CreateMesocycle(MesocycleViewModel mealViewModel, string name)
        {
            var createMesocycleDto = _mapper.Map<CreateMesocycleDto>(mealViewModel);
            createMesocycleDto.Name = name;
            var uri = $"{_baseUrl}/api/Mesocycle";
            await uri.PostJsonAsync(createMesocycleDto);
        }

        public async Task UpdateMesocycle(MesocycleViewModel mealViewModel, string name, Guid id)
        {
            var updateMesocycleDto = _mapper.Map<UpdateMesocycleDto>(mealViewModel);
            updateMesocycleDto.Name = name;
            updateMesocycleDto.Id = id;
            var uri = $"{_baseUrl}/api/Mesocycle";
            await uri.PutJsonAsync(updateMesocycleDto);
        }

        public async Task<IReadOnlyList<MesocycleViewModel>> GetAllMesocycles()
        {
            var uri = $"{_baseUrl}/api/Mesocycle";
            var dtoList = await uri.GetJsonAsync<IReadOnlyList<GetMesocycleDto>>();
            return _mapper.Map<IReadOnlyList<MesocycleViewModel>>(dtoList);
        }

        public async Task<MesocycleViewModel> GetMesocycle(Guid id)
        {
            var uri = $"{_baseUrl}/api/Mesocycle/GetById/{id}";
            var dto = await uri.GetJsonAsync<GetMesocycleDto>();
            var mealViewModel = _mapper.Map<MesocycleViewModel>(dto);
            return mealViewModel;
        }

        public async Task DeleteMesocycle(Guid id)
        {
            var uri = $"{_baseUrl}/api/Mesocycle/{id}";
            await uri.DeleteAsync();
        }
    }

    public interface IMesocycleDataService
    {
        Task CreateMesocycle(MesocycleViewModel viewModel, string name);
        Task UpdateMesocycle(MesocycleViewModel viewModel, string name);
        Task<IReadOnlyList<MesocycleViewModel>> GetAllMesocycles();
        Task<MesocycleViewModel> GetMesocycle(Guid guid);
        Task DeleteMesocycle(Guid guid);
    }
}