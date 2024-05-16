using Ardalis.GuardClauses;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TrackMyMacros.Infrastructure;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public abstract class Generator
{
    protected string OutputDirectory { get; set; }
    protected string BaseDirectory { get; set; }

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
    
    protected virtual Maybe<InterfaceDeclarationSyntax> InterfaceDeclarationSyntax => Maybe.None;
    protected virtual Maybe<ClassDeclarationSyntax> EntireClassDeclarationSyntax => Maybe.None;

    protected virtual List<MethodDeclarationSyntax> MethodDeclarationSyntax => [];
    protected virtual List<MemberDeclarationSyntax> MemberDeclarationSyntaxes => [];
    
    protected virtual List<string> Comments => [];

    protected virtual Maybe<AttributeListSyntax> AttributeListSyntax => Maybe.None;
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
        if (EntireClassDeclarationSyntax.HasValue)
            return EntireClassDeclarationSyntax.Value;
        
        
        
        var classDeclarationSyntax = ClassDeclaration(Identifier(TargetClassName))
            .AddModifiers(Token(SyntaxKind.PublicKeyword));
        if (BaseTypeString != String.Empty)
        {
            classDeclarationSyntax = classDeclarationSyntax.AddBaseListTypes(GetBaseTypes());
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
        
        if (AttributeListSyntax != null)
        {
            classDeclarationSyntax = classDeclarationSyntax.AddAttributeLists(AttributeListSyntax.Value);
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
        public const string ApplicationFeatures = "TrackMyMacros.Application.Features";
        public const string Common = "TrackMyMacros.Application.Common";
        public const string Dtos = "TrackMyMacros.Dtos";
        public const string Services = "TrackMyMacros.App4.Services";
        public const string Persistance = "TrackMyMacros.Application.Contracts.Persistence";
        public const string Automapper = "AutoMapper";
        public const string Mediatr = "MediatR";
        public const string Radzen = "Radzen";
        public const string FluentValidation = "FluentValidation";
        public const string Aggregates = "TrackMyMacros.Domain.Aggregates";
        public const string Mvc = "Microsoft.AspNetCore.Mvc";
        public const string GetListQuery = "TrackMyMacros.Application.Features.{0}.Queries.GetList";
        public const string SystemNet = "System.Net";
        public const string Flurl = "Flurl.Http";
        public const string MicrosoftExtensionsOptions = "Microsoft.Extensions.Options";
        public const string MicrosoftAspNetCoreComponents = "Microsoft.AspNetCore.Components";
        public const string ViewModels = "TrackMyMacros.App4.ViewModels";
        public const string EfCore = "Microsoft.EntityFrameworkCore";

        public const string CreateCommand = "TrackMyMacros.Application.Features.{0}.Commands.Create";
        public const string DeleteCommand = "TrackMyMacros.Application.Features.{0}.Commands.Delete";
        public const string UpdateCommand = "TrackMyMacros.Application.Features.{0}.Commands.Update";
        public const string GetQuery = "TrackMyMacros.Application.Features.{0}.Queries.Get";
    }


    public async Task GenerateAndWriteClass()
    {
        var classDeclarationSyntax = GenerateClassDeclarationSyntax2(ClassDeclaration);
        await WriteClassToFile(classDeclarationSyntax,
            GetUsingNamespaces(BaseEntityClassName),
            TargetClassName);
    }

    public async Task GenerateAndWriteClass2()
    {
        var classDeclarationSyntax = GenerateClassDeclarationSyntax2(ClassDeclaration);
        await WriteClassToFile2(classDeclarationSyntax,
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

    protected async Task WriteClassToFile2(ClassDeclarationSyntax classDeclarationSyntax, UsingDirectiveSyntax[] usings,
        string s)
    {
        var compilationUnit = SyntaxFactory.CompilationUnit()
            .AddUsings(usings);

        var namespaceString = $"{BaseDirectory}{OutputDirectory}"
            .Replace("C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\", "").Replace("\\", ".");
        var namespaceParts = namespaceString.Split(".");
        //remove the last array element
        //if the last element is empty
        if (namespaceParts[^1] == "")
            namespaceParts = namespaceParts.Take(namespaceParts.Length - 1).ToArray();
        
//make each part of the namespace string start with a capital letter
        namespaceString = string.Join(".", namespaceParts.Select(s => char.ToUpper(s[0]) + s.Substring(1)));
        var ns = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(namespaceString))
            .AddMembers(classDeclarationSyntax).WithLeadingTrivia( Comments.Select(m => Comment(m)).ToArray());
        if (InterfaceDeclarationSyntax.HasValue)
        {
            ns= ns.AddMembers(InterfaceDeclarationSyntax.Value);
        }   

        

        compilationUnit = compilationUnit.AddMembers(ns);

        var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        if (!Directory.Exists(@$"{BaseDirectory}{OutputDirectory}"))
        {
            Directory.CreateDirectory(@$"{BaseDirectory}{OutputDirectory}");
        }

        await using var streamWriter = new StreamWriter(
            @$"{BaseDirectory}\{OutputDirectory}\{s}.cs",
            false);
        compilationUnit.NormalizeWhitespace().WriteTo(streamWriter);
    }


    protected FieldDeclarationSyntax GetFieldDeclaration(string fieldName, string typeName) =>
        FieldDeclaration(
            VariableDeclaration(ParseTypeName(typeName))
                .AddVariables(VariableDeclarator(Identifier(fieldName)))
        ).AddModifiers(Token(SyntaxKind.PrivateKeyword));
    
    protected ClassDeclarationSyntax GenerateNewClassDeclaration(ClassDeclarationSyntax classDeclaration,
        string identifier, Func<MemberDeclarationSyntax, bool> predicate, BaseTypeSyntax[] baseTypes)
    {
        var membersToAdd = classDeclaration.Members.Where(m => predicate(m)).ToArray();

        return ClassDeclaration(Identifier(identifier))
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            // .AddBaseListTypes(baseTypes)
            .AddMembers(membersToAdd);
        
    }
}