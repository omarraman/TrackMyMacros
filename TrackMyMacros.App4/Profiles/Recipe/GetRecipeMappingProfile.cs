using AutoMapper;
using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Recipe;

namespace TrackMyMacros.App4.Profiles.Recipe
{
    public class GetRecipeMappingProfile : Profile
    {
        public GetRecipeMappingProfile()
        {
            CreateMap<GetRecipeDto, GetRecipeViewModel>();
        }
    }
}