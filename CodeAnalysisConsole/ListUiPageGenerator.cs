using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;

namespace CodeGen;

public class ListUiPageGenerator : RazorPageGenerator
{
    protected override List<string> Comments {
        get
        {
            return new List<string>
            {
                @$"
/*
                filename will be {BaseEntityClassName}List.razor

                @page ""/{BaseEntityClassName}List""


                @if ({BaseEntityClassName}s != null)
                {{
                    @foreach (var {BaseEntityClassName}ViewModel in {BaseEntityClassName}s)
                    {{
                        <div>
                            @{BaseEntityClassName}ViewModel.Date @{BaseEntityClassName}ViewModel.Weight
                            <RadzenButton Text=""Edit"" ButtonStyle=""ButtonStyle.Primary"" Click=""()=>Edit({BaseEntityClassName}ViewModel.Id)""/>
                            <RadzenButton Text=""Delete"" ButtonStyle=""ButtonStyle.Primary"" Click=""()=>Delete({BaseEntityClassName}ViewModel.Id)""/>
                        </div>
                    }}
                }}
                else
                {{
                    <div>Loading...</div>
                }}

*/
                "
            };
        }
    }

    private StringBuilder GetClassTemplateString { get; set; }

    protected override List<PropertyDeclarationSyntax> PropertyDeclarationSyntaxes
    {
        get
        {
            var list = new List<PropertyDeclarationSyntax>();
            SyntaxTree tree = CSharpSyntaxTree.ParseText(GetClassTemplateString.ToString());
            var handlerDeclaration =
                tree.GetCompilationUnitRoot().DescendantNodes().OfType<PropertyDeclarationSyntax>();
            list.AddRange(handlerDeclaration);

            return list;
        }
    }

    public ListUiPageGenerator(ClassDeclarationSyntax classDeclarationSyntax
    )
        : base(
            classDeclarationSyntax)
    {
        GetClassTemplateString = new StringBuilder();
        GetClassTemplateString.Append($@"
         public class ThisIsJustATemporaryContainerClass
         {{
                public partial class {BaseEntityClassName}List
                {{
                    [Inject] public IGenericDataService _dataService {{ get; set; }}

                    [Inject] public DialogService DialogService {{ get; set; }}
                    [Inject] public IMapper Mapper {{ get; set; }}

                    public IReadOnlyList<Get{BaseEntityClassName}ViewModel> {BaseEntityClassName}s {{ get; set; }}

                    protected override async Task OnInitializedAsync()
                    {{
                        await Refresh();
                    }}

                    private async Task Refresh()
                    {{
                        var temp = await _dataService.GetList<Get{BaseEntityClassName}ViewModel, Get{BaseEntityClassName}Dto>(GenericDataService
                            .Endpoints.{BaseEntityClassName});
                        {BaseEntityClassName}s = temp.OrderByDescending(m => m.Date).ToList();
                    }}

                    private async void Edit(Guid id)
                    {{
                        var viewModel =
                            await _dataService.Get<Get{BaseEntityClassName}ViewModel, Get{BaseEntityClassName}Dto>(
                                $""{{GenericDataService.Endpoints.{BaseEntityClassName}}}/GetById/{{id}}"");
                        var json = JsonConvert.SerializeObject(viewModel);
                        var viewModelCopy = JsonConvert.DeserializeObject<{BaseEntityClassName}ViewModel>(json);
                        await DialogService.OpenAsync<AddOrUpdate{BaseEntityClassName}Dialog>(""Edit {BaseEntityClassName}"",
                            new Dictionary<string, object>
                            {{
                                {{ ""{BaseEntityClassName}"", viewModelCopy }},
                                {{ ""DialogService"", DialogService }},
                                {{ ""EditMode"", true }},
                                {{ ""Id"", id }},
                                {{ ""OnDialogClose"", EventCallback.Factory.Create(this, OnDialogClose) }}
                            }});
                    }}

                    private async void Delete(Guid id)
                    {{
                        await _dataService.Delete($""{{GenericDataService.Endpoints.{BaseEntityClassName}}}/{{id}}"");
                        await Refresh();
                        StateHasChanged();
                    }}

                    private async Task OnDialogClose()
                    {{
                        await Refresh();
                        StateHasChanged();
                    }}
                }}
         }}
         ");
    }


    protected override List<MethodDeclarationSyntax> MethodDeclarationSyntax
    {
        get
        {
            var list = new List<MethodDeclarationSyntax>();
            SyntaxTree tree = CSharpSyntaxTree.ParseText(GetClassTemplateString.ToString());
            var handlerDeclaration = tree.GetCompilationUnitRoot().DescendantNodes().OfType<MethodDeclarationSyntax>();
            list.AddRange(handlerDeclaration);

            return list;
        }
    }




    protected override string TargetClassName => $"{BaseEntityClassName}List";
}