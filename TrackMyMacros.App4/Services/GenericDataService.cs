﻿using AutoMapper;
using Flurl.Http;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.Dtos.Mesocycle;

namespace TrackMyMacros.App4.Services
{
    public interface IGenericDataService
    {
        Task Post<TModel, TDto>(TModel model, string endpoint);
        Task Put<TModel, TDto>(TModel model, string endpoint);
        Task Put<TModel, TDto>(Endpoint endpoint, TModel model);
        Task<IReadOnlyList<TModel>> GetList<TModel, TDto>(string endpoint);
        Task<IReadOnlyList<TModel>> GetList<TModel, TDto>(Endpoint endpoint);
        Task<TModel> Get<TModel, TDto>(string endpoint);
        Task<TModel> Get<TModel, TDto>(Endpoint endpoint, Guid id);
        Task Delete(string endpoint);
    }

    public class GenericDataService : IGenericDataService
    {
        private readonly IMapper _mapper;
        private readonly string? _baseUrl;

        public static class Endpoints
        {
            public const string WeightReading = "WeightReading";
            public const string FoodCombo = "FoodCombo";
            public const string Recipe = "Recipe";
            public const string Mesocycle = "Mesocycle";
        }

        public GenericDataService(IMapper mapper, IConfiguration configuration)
        {
            _baseUrl = configuration["BackendUrl"];
            if (_baseUrl == null)
            {
                throw new ArgumentNullException(nameof(_baseUrl));
            }

            _baseUrl = _baseUrl + "/api/";
            _mapper = mapper;
        }

        public async Task<TModel> Get<TModel, TDto>(Endpoint endpoint, Guid id)
        {
            try
            {
                var uri = _baseUrl + endpoint.Value + "/GetById/" + id;
                var foods = await uri
                    .GetJsonAsync<TDto>();
                // var meso = foods as GetMesocycleDto;
                // var week = meso.Weeks.FirstOrDefault();
                // var workout = week.Workouts.FirstOrDefault();
                // var set = workout.Sets.FirstOrDefault();
                // var setVm = _mapper.Map<GetSetViewModel>(set);
                // var workoutVm = _mapper.Map<GetWorkoutViewModel>(workout);
                return _mapper.Map<TModel>(foods);
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
        }

        public async Task Post<TModel, TDto>(TModel model, string endpoint)
        {
            try
            {
                var dto = _mapper.Map<TDto>(model);
                var uri = _baseUrl + endpoint;
                await uri
                    .PostJsonAsync(dto);
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public async Task Put<TModel, TDto>(TModel model, string endpoint)
        {
            try
            {
                var dto = _mapper.Map<TDto>(model);
                var uri = _baseUrl + endpoint;
                await uri
                    .PutJsonAsync(dto);
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
        }

        public async Task Put<TModel, TDto>(Endpoint endpoint, TModel model)
        {
            try
            {
                var dto = _mapper.Map<TDto>(model);
                var uri = _baseUrl + endpoint.Value;
                await uri
                    .PutJsonAsync(dto);
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
        }


        public async Task<IReadOnlyList<TModel>> GetList<TModel, TDto>(string endpoint)
        {
            try
            {
                var uri = _baseUrl + endpoint;
                var foods = await uri
                    .GetJsonAsync<IReadOnlyList<TDto>>();
                return _mapper.Map<IReadOnlyList<TModel>>(foods);
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
        }

        public async Task<IReadOnlyList<TModel>> GetList<TModel, TDto>(Endpoint endpoint)
        {
            try
            {
                var uri = _baseUrl + endpoint.Value;
                var foods = await uri
                    .GetJsonAsync<IReadOnlyList<TDto>>();
                try
                {
                    var mapped = _mapper.Map<IReadOnlyList<TModel>>(foods);
                    return _mapper.Map<IReadOnlyList<TModel>>(foods);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
        }


        public async Task<TModel> Get<TModel, TDto>(string endpoint)
        {
            try
            {
                var uri = _baseUrl + endpoint;
                var foods = await uri
                    .GetJsonAsync<TDto>();
                return _mapper.Map<TModel>(foods);
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
        }

        public async Task Delete(string endpoint)
        {
            try
            {
                var uri = _baseUrl + endpoint;
                await uri
                    .DeleteAsync();
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
        }
    }
}