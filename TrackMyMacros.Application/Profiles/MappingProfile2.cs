using AutoMapper;
using TrackMyMacros.Domain.Aggregates.FoodCombo;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.Application.Profiles;

public class MappingProfile2:Profile
{
    public MappingProfile2()
    {
        CreateMap<FoodCombo, GetFoodComboDto>();
        // CreateMap<FoodComboAmount, GetFoodComboAmountDto>();
        // //
        //
        // CreateMap<CreateFoodComboDto, CreateFoodComboCommand>();
        // CreateMap<CreateFoodComboAmount, FoodComboAmount>();
        // CreateMap<CreateFoodComboCommand, FoodCombo>()
        //     .ForMember(m=>m.FoodComboAmounts,
        //         o=>o.MapFrom(p=>p.FoodComboAmounts));
        // CreateMap<CreateFoodComboAmountDto, CreateFoodComboAmount>();
        //
        //
        //
        // CreateMap<UpdateFoodComboCommand, FoodCombo>().ForMember(m=>m.FoodComboAmounts,
        //     o=>o.MapFrom(p=>p.FoodComboAmounts));
        // CreateMap<UpdateFoodComboCommand.UpdateFoodComboAmount, FoodComboAmount>()
        //     .ForMember(m=>m.FoodId,o=>o.MapFrom(p=>p.FoodId))
        //     .ForMember(m=>m.Quantity,o=>o.MapFrom(p=>p.Quantity))
        //     ;
        //
    }
}