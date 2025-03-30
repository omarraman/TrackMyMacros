using CodeAnalysisConsole;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CodeGen;

public abstract class RazorPageGenerator:Generator
{
    public bool IsComponent { get; set; } = false;
    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return new[]
        {
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(Generator.UsingStrings.MicrosoftAspNetCoreComponents)),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(Generator.UsingStrings.Services)),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(Generator.UsingStrings.ViewModels)),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName($"{Generator.UsingStrings.Dtos}.{baseEntityName}")),
        };
    }

    public RazorPageGenerator(ClassDeclarationSyntax classDeclarationSyntax, bool isComponent=false)
        : base(
            classDeclarationSyntax)
    {
        BaseDirectory = $"{Constants.RootDirectory}RiderProjects\\TrackMyMacros\\TrackMyMacros.App4\\";
        OutputDirectory = "Pages";
        IsComponent = isComponent;
        if (isComponent) OutputDirectory = "Components";
        
        IsPartial = true;
        ExtensionModifier = "razor";
    
    }
}