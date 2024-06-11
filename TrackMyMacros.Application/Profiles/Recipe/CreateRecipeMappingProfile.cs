using AutoMapper;
using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.Domain.Aggregates.Recipe;
using TrackMyMacros.Application.Features.Recipe.Commands.Create;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Application.Profiles.Recipe
{
    public class CreateRecipeMappingProfile : Profile
    {
        public CreateRecipeMappingProfile()
        {
            CreateMap<CreateRecipeDto, CreateRecipeCommand>();
                // .ForMember(m => m.RecipeFoodAmounts, opt => opt.MapFrom(src => src.RecipeFoodAmounts));
            ;
            CreateMap<CreateRecipeDto.CreateRecipeFoodAmountDto, CreateRecipeCommand.CreateRecipeFoodAmount>();
            CreateMap<CreateRecipeCommand, Domain.Aggregates.Recipe.Recipe>()
                // .ForMember(m => m.RecipeFoodAmounts, opt => opt.MapFrom(src => src.RecipeFoodAmounts));
            ;
            CreateMap<CreateRecipeCommand.CreateRecipeFoodAmount, RecipeFoodAmount>();
        }
    }
}