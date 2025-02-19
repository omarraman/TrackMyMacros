using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public abstract class HandlerClassGenerator : Generator
{
    private HandlerType _handlerType;

    public enum HandlerType
    {
        Create,
        Update,
        Get,
        Delete,
        GetList
    }

    public HandlerClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,
        HandlerType handlerType) : base(classDeclarationSyntax)
    {
        _handlerType = handlerType;


    }

    
    protected override string BaseTypeString
    {
        get
        {
            switch (_handlerType)
            {
                case HandlerType.Create:
                    return $"IRequestHandler<{CommandOrQueryIdentifier.Create(BaseEntityClassName)},Result<Guid>>";
                case HandlerType.Update:
                    return $"IRequestHandler<{CommandOrQueryIdentifier.Update(BaseEntityClassName)},Result>";
                case HandlerType.Get:
                    return $"IRequestHandler<{CommandOrQueryIdentifier.Get(BaseEntityClassName)},Maybe<{DtoIdentifier.Get(BaseEntityClassName)}>>";
                case HandlerType.Delete:
                    return $"IRequestHandler<{CommandOrQueryIdentifier.Delete(BaseEntityClassName)},Result>";
                case HandlerType.GetList:
                    return $"IRequestHandler<{CommandOrQueryIdentifier.GetList(BaseEntityClassName)},IReadOnlyList<{DtoIdentifier.Get(BaseEntityClassName)}>>";
                default:
                    throw new System.NotImplementedException();
            }
        }

    }

    protected override string TargetClassName
    {
        get
        {
            var extension = "CommandHandler";

            if (_handlerType.ToString().StartsWith("Get"))
                extension = "QueryHandler";

            return _handlerType.ToString() + BaseEntityClassName + extension;
        }
    }

    protected override List<FieldDeclarationSyntax> FieldDeclarationSyntaxList =>
    [
        GetMapperFieldDeclaration(),
        GetRepositoryFieldDeclaration(BaseEntityClassName)
    ];

    protected override List<MethodDeclarationSyntax> MethodDeclarationSyntax {
        get
        {
            var list = new List<MethodDeclarationSyntax>();
            SyntaxTree tree = CSharpSyntaxTree.ParseText(HandlerMethodString.ToString());
            var handlerDeclaration= tree.GetCompilationUnitRoot().DescendantNodes().OfType<MethodDeclarationSyntax>().First();
            list.Add(handlerDeclaration);
            return list;
        }
    }

    protected StringBuilder HandlerMethodString { get; set; } = new StringBuilder();

    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return new[]
        {
            UsingDirective(ParseName(UsingStrings.Automapper)),
            UsingDirective(ParseName(UsingStrings.Mediatr)),
        };
    }

    protected override Maybe<ConstructorDeclarationSyntax> ConstructorDeclarationSyntax {
        get
        {
            return ConstructorDeclaration(Identifier(TargetClassName))
                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                .AddParameterListParameters(Parameter(Identifier("mapper")).WithType(ParseTypeName("IMapper")))
                .AddParameterListParameters(Parameter(Identifier($"{BaseEntityClassNameInCamelCase}Repository"))
                    .WithType(ParseTypeName($"I{BaseEntityClassName}Repository")))
                .AddBodyStatements(
                    ExpressionStatement(
                        AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName($"_{BaseEntityClassNameInCamelCase}Repository"),
                            IdentifierName($"{BaseEntityClassNameInCamelCase}Repository"))),
                    ExpressionStatement(
                        AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName("_mapper"),
                            IdentifierName("mapper")))
                );
        }
    }


    protected FieldDeclarationSyntax GetMapperFieldDeclaration() =>
        GetFieldDeclaration("_mapper", "IMapper");

    protected FieldDeclarationSyntax GetRepositoryFieldDeclaration(string baseEntityClassName) =>
        GetFieldDeclaration(
            $"_{System.Text.Json.JsonNamingPolicy.CamelCase.ConvertName(baseEntityClassName)}Repository",
            $"I{baseEntityClassName}Repository");


    // protected FieldDeclarationSyntax GetRepositoryFieldDeclaration(string baseEntityClassName) =>
    //     GetFieldDeclaration(
    //         "cd",
    //         "ab"));
}