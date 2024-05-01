using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class AddOrUpdateDialogGenerator : Generator
{

    private StringBuilder DialogClassDefinitionString { get; set; }


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
            classDeclarationSyntax)
    {

        BaseDirectory="C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.App2\\Components";
        OutputDirectory = "";
        DialogClassDefinitionString = new StringBuilder();
        DialogClassDefinitionString.Append($@"
        public class Test
        {{
            public partial class AddOrUpdate{BaseEntityClassName}Dialog
                {{
                    [Parameter]
                    public DialogService DialogService {{ get; set; }}
                    
                    [Parameter] public {BaseEntityClassName}ViewModel {BaseEntityClassName} {{ get; set; }}
                    
                    [Parameter]
                    public EventCallback OnDialogClose {{ get; set; }}
                    
                    [Inject] public I{BaseEntityClassName}DataService _foodComboDataService {{ get; set; }}

                    [Inject] public IMapper Mapper {{ get; set; }}

                    [Parameter]
                    public string {BaseEntityClassName}Name {{ get; set; }}

                    [Parameter] public Guid Id {{ get; set; }}
                    [Parameter] public bool EditMode {{ get; set; }} = false;
                    public async Task SaveAndClose()
                    {{
                        if (EditMode)
                        {{
                            await _foodComboDataService.Update{BaseEntityClassName}Combo({BaseEntityClassName}, {BaseEntityClassName}Name, Id);
                        }}
                        else
                        {{
                            await _foodComboDataService.Create{BaseEntityClassName}Combo({BaseEntityClassName}, {BaseEntityClassName}Name);
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