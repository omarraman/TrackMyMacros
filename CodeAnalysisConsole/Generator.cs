using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
namespace CodeGen;

public abstract class Generator
{
    protected string _baseTypeString;
    public string BaseEntityClassNameInCamelCase { get; set; }

    protected string BaseEntityClassName { get; set; }
    
    protected string TargetClassName { get; set; }

    public ClassDeclarationSyntax ClassDeclaration { get; set; }

    public Generator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        ClassDeclaration = classDeclarationSyntax;
        BaseEntityClassName = classDeclarationSyntax.Identifier.Text;
        BaseEntityClassNameInCamelCase =
            System.Text.Json.JsonNamingPolicy.CamelCase.ConvertName(BaseEntityClassName);
    }

    protected Generator()
    {
        throw new NotImplementedException();
    }

    protected  SimpleBaseTypeSyntax GetBaseTypes(string className)
    {
        return SimpleBaseType(
            ParseTypeName(_baseTypeString));
    }
    public class UsingStrings
    {
        public const string Infrastructure = "TrackMyMacros.Infrastructure";
        public const string Application = "TrackMyMacros.Application";
        public const string Common = "TrackMyMacros.Application.Common";
        public const string Dtos = "TrackMyMacros.Dtos";
        public const string Persistance = "TrackMyMacros.Application.Contracts.Persistence";
        public const string Automapper = "AutoMapper";
        public const string Mediatr = "MediatR";
    
    }
    protected async Task WriteClassToFile(ClassDeclarationSyntax classDeclarationSyntax, UsingDirectiveSyntax[] usings,
        string s)
    {
        var compilationUnit = SyntaxFactory.CompilationUnit()
            .AddUsings(usings);

        var ns = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName("CodeGen"))
            .AddMembers(classDeclarationSyntax);


        compilationUnit = compilationUnit.AddMembers(ns);

        await using var streamWriter = new StreamWriter(
            @$"C:\Users\OmarRaman\RiderProjects\TrackMyMacros\CodeAnalysisConsole\generated{s}.cs",
            false);
        compilationUnit.NormalizeWhitespace().WriteTo(streamWriter);
    }
}