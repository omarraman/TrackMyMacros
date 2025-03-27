using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class DataServiceGenerator : Generator
{

    private StringBuilder ClassDefinitionString { get; set; }

    protected FieldDeclarationSyntax GetMapperFieldDeclaration() =>
        GetFieldDeclaration("_mapper", "IMapper");

    protected FieldDeclarationSyntax GetBaseUrlDeclaration() =>
        GetFieldDeclaration("_baseUrl", "string");
    
    protected override List<FieldDeclarationSyntax> FieldDeclarationSyntaxList =>
    [
        GetMapperFieldDeclaration(),
        GetBaseUrlDeclaration()
    ];
    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return new[]
        {
            UsingDirective(ParseName(UsingStrings.Automapper)),
            UsingDirective(ParseName(UsingStrings.Dtos)),
            UsingDirective(ParseName(UsingStrings.SystemNet)),
            UsingDirective(ParseName(UsingStrings.Flurl)),
            UsingDirective(ParseName(UsingStrings.MicrosoftExtensionsOptions)),
            UsingDirective(ParseName(UsingStrings.ViewModels)),
            UsingDirective(ParseName($"{UsingStrings.Dtos}")),
            UsingDirective(ParseName($"{UsingStrings.Dtos}.{baseEntityName}")),
            UsingDirective(ParseName($"{UsingStrings.Infrastructure}")),
        };
    }
    
    protected override Maybe<ConstructorDeclarationSyntax> ConstructorDeclarationSyntax {
        get 
        {
            return ConstructorDeclaration(Identifier(TargetClassName))
                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                .AddParameterListParameters(Parameter(Identifier("mapper")).WithType(ParseTypeName("IMapper")))
                .AddParameterListParameters(Parameter(Identifier("baseUrl")).WithType(ParseTypeName("string?")))
                .AddBodyStatements(
                    ExpressionStatement(
                        AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName($"_baseUrl"),
                            IdentifierName($"baseUrl"))),
                    ExpressionStatement(
                        AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName("_mapper"),
                            IdentifierName("mapper")))
                );
        }
    }
    


    public DataServiceGenerator(ClassDeclarationSyntax classDeclarationSyntax
    )
        : base(
            classDeclarationSyntax)
    {

        BaseDirectory=$"{Constants.RootDirectory}RiderProjects\\TrackMyMacros\\TrackMyMacros.App4\\Services\\";
        OutputDirectory = "";
        ClassDefinitionString = new StringBuilder();
        ClassDefinitionString.Append($@"
            public class {BaseEntityClassName}DataService: I{BaseEntityClassName}DataService
            {{
                private readonly IMapper _mapper;
                private readonly string? _baseUrl;

                public {BaseEntityClassName}DataService(IMapper mapper,IConfiguration configuration)
                {{
                    _baseUrl = configuration[""BackendUrl""];
                    _mapper = mapper;
                }}

                public async Task Create{BaseEntityClassName}({BaseEntityClassName}ViewModel mealViewModel,string name)
                {{
                        var create{BaseEntityClassName}Dto = _mapper.Map<Create{BaseEntityClassName}Dto>(mealViewModel);
                        create{BaseEntityClassName}Dto.Name = name;
                        var uri = $""{{_baseUrl}}/api/{BaseEntityClassName}"";
                        await uri
                            .PostJsonAsync(create{BaseEntityClassName}Dto);
                }}
                
                public async Task Update{BaseEntityClassName}({BaseEntityClassName}ViewModel mealViewModel,string name,Guid id)
                {{
                        var update{BaseEntityClassName}Dto = _mapper.Map<Update{BaseEntityClassName}Dto>(mealViewModel);
                        update{BaseEntityClassName}Dto.Name = name;
                        update{BaseEntityClassName}Dto.Id = id;
                        var uri = $""{{_baseUrl}}/api/{BaseEntityClassName}"";
                        await uri
                            .PutJsonAsync(update{BaseEntityClassName}Dto);
                }}
                public async Task<IReadOnlyList<{BaseEntityClassName}ViewModel>> GetAll{BaseEntityClassName}s()
                {{
                        var uri = $""{{_baseUrl}}/api/{BaseEntityClassName}"";
                        var dtoList = await uri
                            .GetJsonAsync<IReadOnlyList<Get{BaseEntityClassName}Dto>>();
                        return _mapper.Map<IReadOnlyList<{BaseEntityClassName}ViewModel>>(dtoList);
                }}
                
                public async Task<{BaseEntityClassName}ViewModel> Get{BaseEntityClassName}(Guid id)
                {{
                        var uri = $""{{_baseUrl}}/api/{BaseEntityClassName}/GetById/{{id}}"";
                        var dto= await uri
                            .GetJsonAsync<Get{BaseEntityClassName}Dto>();
                        var mealViewModel = _mapper.Map<{BaseEntityClassName}ViewModel>(dto);
                        return mealViewModel;
                }}
                
                public async Task Delete{BaseEntityClassName}(Guid id)
                {{
                        var uri = $""{{_baseUrl}}/api/{BaseEntityClassName}/{{id}}"";
                        await uri
                            .DeleteAsync();
                }}
            }}

        ");

    }


    protected override Maybe<InterfaceDeclarationSyntax> InterfaceDeclarationSyntax {
        get
        {
            var x = new StringBuilder();
            x.Append($@"
                public interface I{BaseEntityClassName}DataService
                {{
                    Task Create{BaseEntityClassName}({BaseEntityClassName}ViewModel viewModel,string name);
                    Task Update{BaseEntityClassName}({BaseEntityClassName}ViewModel viewModel,string name);
                    Task<IReadOnlyList<{BaseEntityClassName}ViewModel>> GetAll{BaseEntityClassName}s();
                    Task<{BaseEntityClassName}ViewModel> Get{BaseEntityClassName}(Guid guid);
                    Task Delete{BaseEntityClassName}(Guid guid);
                }}"
            );
            SyntaxTree tree = CSharpSyntaxTree.ParseText(x.ToString());
            var interfaceDeclarationSyntax = tree.GetCompilationUnitRoot().DescendantNodes().OfType<InterfaceDeclarationSyntax>().First();
            return interfaceDeclarationSyntax;
        }
    }

    protected override List<MethodDeclarationSyntax> MethodDeclarationSyntax {
        get
        {
            var list = new List<MethodDeclarationSyntax>();
            SyntaxTree tree = CSharpSyntaxTree.ParseText(ClassDefinitionString.ToString());
            var handlerDeclaration= tree.GetCompilationUnitRoot().DescendantNodes().OfType<MethodDeclarationSyntax>();
            list.AddRange(handlerDeclaration);
            return list;
        }
    }

    protected override string BaseTypeString =>
        $"I{BaseEntityClassName}DataService";


    protected override string TargetClassName => $"{BaseEntityClassName}DataService";

}