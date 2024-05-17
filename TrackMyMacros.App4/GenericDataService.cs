﻿using AutoMapper;
using Flurl.Http;
using TrackMyMacros.App4.TrackMyMacros.App2.Services;
using IGenericDataService = TrackMyMacros.App4.Services.IGenericDataService;

namespace TrackMyMacros.App2
{
    using AutoMapper;
    using Flurl.Http;
}

namespace TrackMyMacros.App2.TrackMyMacros.App2.Services
{
    public interface IGenericDataServicex
    {
        Task Post<TModel,TDto>(TModel model,string endpoint);
        Task Put<TModel,TDto>(TModel model,string endpoint);
        Task<IReadOnlyList<TModel>> GetList<TModel,TDto>(string endpoint );
        Task<TModel> Get<TModel,TDto>(string endpoint );
    }
}

namespace TrackMyMacros.App2.Services
{
    public class GenericDataServicex :IGenericDataServicex
    {
        private readonly IMapper _mapper;
        private readonly string? _baseUrl;

        public static class Endpoints
        {
            public const string WeightReading = "WeightReading";
            public const string FoodCombo = "FoodCombo";
        }

        public GenericDataServicex( IMapper mapper,IConfiguration configuration)
        {
            _baseUrl = configuration["BackendUrl"];
            if (_baseUrl==null)
            {
                throw new ArgumentNullException(nameof(_baseUrl));
            }
         
            _baseUrl= _baseUrl +  "api/";
            _mapper = mapper;
        }


        public async Task Post<TModel,TDto>(TModel model,string endpoint)
        {
            try
            {
                var dto = _mapper.Map<TDto>(model);
                var uri = _baseUrl + "/" + endpoint;
                await uri
                    .PostJsonAsync(dto);
            }
            catch (FlurlHttpException ex)
            {
                var string1 = await ex.GetResponseStringAsync();
                throw new Exception(string1);
            }
        }
    
    
        public async Task Put<TModel,TDto>(TModel model,string endpoint)
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
        }
    
        public async Task<IReadOnlyList<TModel>> GetList<TModel,TDto>(string endpoint )
        {
            try
            {
                var uri =  _baseUrl + endpoint;
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
    
        public async Task<TModel> Get<TModel,TDto>(string endpoint )
        {
            try
            {
                var uri =  _baseUrl + endpoint;
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

    }
}