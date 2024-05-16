using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class MappingProfileGenerator : Generator
{
    private MappingProfileType _mappingProfileType;
    private StringBuilder MappingProfileMethodString { get; set; } = new StringBuilder();

    public static MappingProfileGenerator CreateMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        return new MappingProfileGenerator(classDeclarationSyntax, MappingProfileType.Create);
    }

    public static MappingProfileGenerator UpdateMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        return new MappingProfileGenerator(classDeclarationSyntax, MappingProfileType.Update);
    }

    public static MappingProfileGenerator GetMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        return new MappingProfileGenerator(classDeclarationSyntax, MappingProfileType.Get);
    }

    protected override Maybe<ConstructorDeclarationSyntax> ConstructorDeclarationSyntax
    {
        get
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(MappingProfileMethodString.ToString());
            var constructorDeclarationSyntax = tree.GetCompilationUnitRoot().DescendantNodes()
                .OfType<ConstructorDeclarationSyntax>().First();
            return constructorDeclarationSyntax;
        }
    }

    private MappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax, MappingProfileType mappingProfileType
        // , List<ClassDeclarationSyntax> valueObjects
    )
        : base(
            classDeclarationSyntax)
    {
        _mappingProfileType = mappingProfileType;
        BaseDirectory =
            "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.Application\\Profiles\\";
        OutputDirectory = $"{BaseEntityClassName}\\";
        switch (mappingProfileType)
        {
            case MappingProfileType.Update:
            case MappingProfileType.Create:
                MappingProfileMethodString.Append($@"
public class {mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile(){{
    public {mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile()
    {{
        CreateMap<{mappingProfileType.ToString()}{BaseEntityClassName}Dto, {mappingProfileType.ToString()}{BaseEntityClassName}Command>();
        CreateMap<{mappingProfileType.ToString()}{BaseEntityClassName}Command, Domain.Aggregates.{BaseEntityClassName}.{BaseEntityClassName}>();
}}
");
                break;
            case MappingProfileType.Get:
                MappingProfileMethodString.Append($@"
public class {mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile(){{
    public {mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile()
    {{
        CreateMap<Domain.Aggregates.{BaseEntityClassName}.{BaseEntityClassName}, {mappingProfileType.ToString()}{BaseEntityClassName}Dto>();
}}
");
                break;
        }
    }


    protected override string BaseTypeString =>
        $"Profile";


    protected override string TargetClassName => $"{_mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile";


    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        var directives = new[]
        {
            UsingDirective(ParseName(UsingStrings.Automapper)),
            UsingDirective(ParseName($"{UsingStrings.Dtos}.{baseEntityName}")),
            UsingDirective(ParseName($"{UsingStrings.Aggregates}.{baseEntityName}")),
        };

        if (_mappingProfileType == MappingProfileType.Update || _mappingProfileType == MappingProfileType.Create)
        {
            directives = directives
                .Append(UsingDirective(
                    ParseName($"{UsingStrings.ApplicationFeatures}.{baseEntityName}.Commands.{_mappingProfileType}")))
                .ToArray();
        }


        return directives;
    }

    public enum MappingProfileType
    {
        Create,
        Update,
        Get
    }
}