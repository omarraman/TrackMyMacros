using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;

namespace CodeGen;

public class AddEntityPageCodeBehindGenerator : RazorPageGenerator
{
    protected override List<string> Comments {
        get
        {
            return new List<string>
            {
                @$"
/*
                filename will be Create{BaseEntityClassName}.razor

                @page ""/AddNew{BaseEntityClassName}""
                @using global::TrackMyMacros.App4.ViewModels

                <div class=""container"">

                    <div class=""row py-1"">
                        <div class=""col"">
                            <RadzenDatePicker DateFormat=""dd/MM/yyyy"" @bind-Value=""Create{BaseEntityClassName}ViewModel.Date""/>
                        </div>
                    </div>
                    <div class=""row py-1"">
                        <div class=""col"">
                            <RadzenNumeric TValue=""double"" @bind-Value=""Create{BaseEntityClassName}ViewModel.Weight"" Min=""65"" Max=""85""></RadzenNumeric>
                        </div>
                    </div>
                    <div class=""rz-p-12 rz-text-align-center"">
                        <RadzenButton Text=""Save"" ButtonStyle=""ButtonStyle.Secondary"" Click=""SaveAndClose""/>
                    </div>

                </div>

                @foreach (var alert in AlertMessages)
                {{
                    <RadzenAlert AlertStyle=""AlertStyle.Warning"" Variant=""Variant.Flat"" Shade=""Shade.Lighter"">
                        Record saved
                    </RadzenAlert>
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

    public AddEntityPageCodeBehindGenerator(ClassDeclarationSyntax classDeclarationSyntax
    )
        : base(
            classDeclarationSyntax)
    {
        GetClassTemplateString = new StringBuilder();
        GetClassTemplateString.Append($@"
         public class ThisIsJustATemporaryContainerClass
         {{
            public partial class AddNew{BaseEntityClassName}
            {{
                [Inject] public IGenericDataService DataService {{ get; set; }}

                public Create{BaseEntityClassName}ViewModel Create{BaseEntityClassName}ViewModel {{ get; set; }}

                private List<string> AlertMessages {{ get; set; }} = new();

                public async Task SaveAndClose()
                {{
                    await DataService.Post<Create{BaseEntityClassName}ViewModel, Create{BaseEntityClassName}Dto>(Create{BaseEntityClassName}ViewModel,
                        GenericDataService.Endpoints.{BaseEntityClassName});
                    
                    InitializeViewModel();
                    AlertMessages.Add(""Record Added"");
                    StateHasChanged();
                }}

                protected async override Task OnInitializedAsync()
                {{
                    InitializeViewModel();
                }}

                private void InitializeViewModel()
                {{
                    Create{BaseEntityClassName}ViewModel = new Create{BaseEntityClassName}ViewModel
                    {{

                    }};
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




    protected override string TargetClassName => $"Create{BaseEntityClassName}";
}