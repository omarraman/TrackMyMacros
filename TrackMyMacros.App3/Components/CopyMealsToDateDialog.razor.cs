using Microsoft.AspNetCore.Components;
using Radzen;

namespace TrackMyMacros.App3.Components;

public partial class CopyMealsToDateDialog
{
    [Parameter]
    public DialogService DialogService { get; set; }
    [Parameter]
    public EventCallback<DateOnly> OnCopyMealsToDate { get; set; }
    [Parameter]
    public EventCallback OnCancel { get; set; }
    public DateTime SelectedDate { get; set; }
    
    
    public async Task OnCopyMealsToDateClicked()
    {
        await OnCopyMealsToDate.InvokeAsync(DateOnly.FromDateTime(SelectedDate));
        DialogService.Close();
    }
    
    public void OnCancelClicked()
    {
        DialogService.Close();
    }
} 