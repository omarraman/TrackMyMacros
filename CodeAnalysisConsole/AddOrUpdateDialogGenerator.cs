using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class AddOrUpdateDialogGenerator : RazorPageGenerator
{

    private StringBuilder DialogClassDefinitionString { get; set; }

    protected override List<string> Comments {
        get
        {
            return new List<string>
            {
                @$"
/*
                filename will be AddOrUpdate{BaseEntityClassName}Dialog.razor

                <div class=""row py-1"">
                    <div class=""col"">
                        <RadzenDatePicker DateFormat=""MM/dd/yyyy"" @bind-Value=@WeightReading.Date/>
                    </div>
                </div>
                <div class=""row py-1"">
                    <div class=""col"">
                        <RadzenNumeric TValue=""double"" @bind-Value=""WeightReading.Weight"" Min=""65"" Max=""85""></RadzenNumeric>
                    </div>
                </div>
                <div class=""rz-p-12 rz-text-align-center"">
                    <RadzenButton Text=""Ok"" ButtonStyle=""ButtonStyle.Secondary"" Click=""SaveAndClose""/>
                    <RadzenButton Text=""Cancel"" ButtonStyle=""ButtonStyle.Secondary"" Click=""CancelClicked""/>
                </div>
            */
                "
            };
        }
    }
    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return new[]
        {
            UsingDirective(ParseName(UsingStrings.Automapper)),
            UsingDirective(ParseName(UsingStrings.MicrosoftAspNetCoreComponents)),
            UsingDirective(ParseName(UsingStrings.Services)),
            UsingDirective(ParseName(UsingStrings.ViewModels)),
            UsingDirective(ParseName(UsingStrings.Radzen)),
            UsingDirective(ParseName(UsingStrings.Dtos)),
            UsingDirective(ParseName($"{UsingStrings.Dtos}.{baseEntityName}")),

        };
    }
    
    public AddOrUpdateDialogGenerator(ClassDeclarationSyntax classDeclarationSyntax
    )
        : base(
            classDeclarationSyntax, true)
    {
        DialogClassDefinitionString = new StringBuilder();
        DialogClassDefinitionString.Append($@"
        public class Test
        {{
            public partial class AddOrUpdate{BaseEntityClassName}Dialog
                {{
                    //note if a list page is invoking this as a dialog  then the paramters must match at the invocation site otherwise you get a blank dialog
                    [Parameter]
                    public DialogService DialogService {{ get; set; }}
                    
                    [Parameter] public Create{BaseEntityClassName}ViewModel {BaseEntityClassName} {{ get; set; }}
                    
                    [Parameter]
                    public EventCallback OnDialogClose {{ get; set; }}
                    
                    [Inject] public IGenericDataService _dataService {{ get; set; }}

                    [Inject] public IMapper Mapper {{ get; set; }}

                    [Parameter]
                    public string {BaseEntityClassName}Name {{ get; set; }}

                    [Parameter] public Guid Id {{ get; set; }}
                    [Parameter] public bool EditMode {{ get; set; }} = false;
                    public async Task SaveAndClose()
                    {{
                        if (EditMode)
                        {{
                            await _dataService.Put<Update{BaseEntityClassName}ViewModel,Update{BaseEntityClassName}Dto>({BaseEntityClassName}, Endpoints.{BaseEntityClassName});
                        }}
                        else
                        {{
                            await _dataService.Post<Create{BaseEntityClassName}ViewModel,Create{BaseEntityClassName}Dto>({BaseEntityClassName}, {BaseEntityClassName}Name);
                        }}

                        await OnDialogClose.InvokeAsync();
                        DialogService.Close();
                    }}
                    
                    public void CancelClicked()
                    {{
                        DialogService.Close();
                    }}
                    
                }} 
        }}
        ");

    }
    
    protected override Maybe<ClassDeclarationSyntax> EntireClassDeclarationSyntax {
        get
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(DialogClassDefinitionString.ToString());
            return  tree.GetCompilationUnitRoot().DescendantNodes().OfType<ClassDeclarationSyntax>().First().DescendantNodes().OfType<ClassDeclarationSyntax>().First();
        }
    }



    protected override string TargetClassName => $"AddOrUpdate{BaseEntityClassName}Dialog";

}