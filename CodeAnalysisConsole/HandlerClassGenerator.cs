using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class HandlerClassGenerator : Generator
{

    public HandlerClassGenerator(ClassDeclarationSyntax classDeclarationSyntax) : base(classDeclarationSyntax)
    {
    }

    protected StringBuilder HandlerMethodString { get; set; } = new StringBuilder();
    protected string HandlerName { get; set; }

    protected virtual UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return new[]
        {
            UsingDirective(ParseName(UsingStrings.Automapper)),
            UsingDirective(ParseName(UsingStrings.Mediatr)),
        };
    }

    protected ClassDeclarationSyntax GenerateClassDeclarationSyntax(ClassDeclarationSyntax classDeclaration,
        string identifier,
        FieldDeclarationSyntax[] fieldDeclarations,
        // Func<PropertyDeclarationSyntax, bool> predicate,
        ConstructorDeclarationSyntax constructor,
        MethodDeclarationSyntax handlerMethodDeclaration,
        SimpleBaseTypeSyntax baseListTypes) =>
        ClassDeclaration(SyntaxFactory.Identifier(identifier))
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddBaseListTypes(baseListTypes)
            .AddMembers(fieldDeclarations)
            .AddMembers(constructor)
            .AddMembers(handlerMethodDeclaration);

    public ConstructorDeclarationSyntax GetConstructor(string baseEntityClassName)
    {
        var baseEntityClassNameInCamelCase =
            System.Text.Json.JsonNamingPolicy.CamelCase.ConvertName(baseEntityClassName);
        return ConstructorDeclaration(Identifier(HandlerName))
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            .AddParameterListParameters(Parameter(Identifier("mapper")).WithType(ParseTypeName("IMapper")))
            .AddParameterListParameters(Parameter(Identifier($"{baseEntityClassNameInCamelCase}Repository"))
                .WithType(ParseTypeName($"I{baseEntityClassName}Repository")))
            .AddBodyStatements(
                ExpressionStatement(
                    AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                        IdentifierName($"_{baseEntityClassNameInCamelCase}Repository"),
                        IdentifierName($"{baseEntityClassNameInCamelCase}Repository"))),
                ExpressionStatement(
                    AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                        IdentifierName("_mapper"),
                        IdentifierName("mapper")))
            );
    }


    public async  Task GenerateAndWriteCommandOrQueryHandlerClass()
    {
        SyntaxTree tree = CSharpSyntaxTree.ParseText(HandlerMethodString.ToString());
    
        var classDeclarationSyntax = GenerateClassDeclarationSyntax(ClassDeclaration, TargetClassName,
            [GetMapperFieldDeclaration(), GetRepositoryFieldDeclaration(BaseEntityClassName)], GetConstructor(BaseEntityClassName),
            tree.GetCompilationUnitRoot().DescendantNodes().OfType<MethodDeclarationSyntax>().First(),
            GetBaseTypes(BaseEntityClassName));
        await WriteClassToFile(classDeclarationSyntax,
            GetUsingNamespaces(BaseEntityClassName),
            TargetClassName);
    }
    private FieldDeclarationSyntax GetFieldDeclaration(string fieldName, string typeName) =>
        FieldDeclaration(
            VariableDeclaration(ParseTypeName(typeName))
                .AddVariables(VariableDeclarator(Identifier(fieldName)))
        ).AddModifiers(Token(SyntaxKind.PrivateKeyword));

    // private FieldDeclarationSyntax GetFieldDeclaration(string fieldName, TypeSyntax typeSyntax) =>
    //     FieldDeclaration(
    //         VariableDeclaration(typeSyntax)
    //             .AddVariables(VariableDeclarator(Identifier(fieldName)))
    //     ).AddModifiers(Token(SyntaxKind.PrivateKeyword));

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