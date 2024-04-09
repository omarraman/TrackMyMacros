using Ardalis.GuardClauses;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TrackMyMacros.Infrastructure;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public abstract class Generator
{
    protected virtual string BaseTypeString
    {
        get { return String.Empty; }
    }

    public string BaseEntityClassNameInCamelCase { get; set; }

    protected string BaseEntityClassName { get; set; }

    protected virtual string TargetClassName
    {
        get { throw new NotImplementedException(); }
    }

    protected virtual List<FieldDeclarationSyntax> FieldDeclarationSyntaxList => [];

    protected virtual Maybe<ConstructorDeclarationSyntax> ConstructorDeclarationSyntax => Maybe.None;

    protected virtual List<MethodDeclarationSyntax> MethodDeclarationSyntax => [];
    protected virtual List<MemberDeclarationSyntax> MemberDeclarationSyntaxes => [];
    public ClassDeclarationSyntax ClassDeclaration { get; set; }

    public Generator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        ClassDeclaration = Guard.Against.Null(classDeclarationSyntax, nameof(classDeclarationSyntax));
        BaseEntityClassName = classDeclarationSyntax.Identifier.Text;
        BaseEntityClassNameInCamelCase =
            System.Text.Json.JsonNamingPolicy.CamelCase.ConvertName(BaseEntityClassName);
        // TargetClassName = GetTargetClassName();
        // Guard.Against.NullOrEmpty(BaseTypeString, nameof(BaseTypeString));
        // Guard.Against.NullOrEmpty(TargetClassName, nameof(TargetClassName));
    }

    protected virtual ClassDeclarationSyntax GenerateClassDeclarationSyntax2(ClassDeclarationSyntax classDeclaration)
    {
        var classDeclarationSyntax = ClassDeclaration(Identifier(TargetClassName))
            .AddModifiers(Token(SyntaxKind.PublicKeyword));
        if (BaseTypeString != String.Empty)
        {
            classDeclarationSyntax= classDeclarationSyntax.AddBaseListTypes(GetBaseTypes());
            ;
        }

        if (FieldDeclarationSyntaxList.Any())
        {
            FieldDeclarationSyntaxList.ForEach(fds => classDeclarationSyntax = classDeclarationSyntax.AddMembers(fds));
        }

        if (ConstructorDeclarationSyntax.HasValue)
        {
            classDeclarationSyntax = classDeclarationSyntax.AddMembers(ConstructorDeclarationSyntax.Value);
        }

        if (MethodDeclarationSyntax.Any())
        {
            MethodDeclarationSyntax.ForEach(md => classDeclarationSyntax = classDeclarationSyntax.AddMembers(md));
        }

        if (MemberDeclarationSyntaxes.Any())
        {
            MemberDeclarationSyntaxes.ForEach(mds => classDeclarationSyntax = classDeclarationSyntax.AddMembers(mds));
        }
        return classDeclarationSyntax;
    }

    protected virtual string GetTargetClassName()
    {
        throw new NotImplementedException();
    }
    
    protected virtual UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return [];
    }

    // protected virtual string GetBaseTypeString()
    // {
    //     throw new NotImplementedException();
    // }

    protected Generator()
    {
        throw new NotImplementedException();
    }

    protected SimpleBaseTypeSyntax GetBaseTypes()
    {
        return SimpleBaseType(
            ParseTypeName(BaseTypeString));
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
        public const string FluentValidation = "FluentValidation";
    }

    
    public async Task GenerateAndWriteClass()
    {
        var classDeclarationSyntax = GenerateClassDeclarationSyntax2(ClassDeclaration);
        await WriteClassToFile(classDeclarationSyntax,
            GetUsingNamespaces(BaseEntityClassName),
            TargetClassName);
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