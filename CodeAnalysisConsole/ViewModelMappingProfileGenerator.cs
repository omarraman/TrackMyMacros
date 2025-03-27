using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class ViewModelMappingProfileGenerator : Generator
{
    private ViewModelMappingProfileType _viewModelMappingProfileType;
    private StringBuilder MappingProfileMethodString { get; set; } = new StringBuilder();

    public static ViewModelMappingProfileGenerator CreateViewModelMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        return new ViewModelMappingProfileGenerator(classDeclarationSyntax, ViewModelMappingProfileType.Create);
    }

    public static ViewModelMappingProfileGenerator UpdateViewModelMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        return new ViewModelMappingProfileGenerator(classDeclarationSyntax, ViewModelMappingProfileType.Update);
    }

    public static ViewModelMappingProfileGenerator GetViewModelMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        return new ViewModelMappingProfileGenerator(classDeclarationSyntax, ViewModelMappingProfileType.Get);
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


    private ViewModelMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax, ViewModelMappingProfileType viewModelMappingProfileType
        // , List<ClassDeclarationSyntax> valueObjects
    )
        : base(
            classDeclarationSyntax)
    {
        _viewModelMappingProfileType = viewModelMappingProfileType;
        BaseDirectory =
            $"{Constants.RootDirectory}RiderProjects\\TrackMyMacros\\TrackMyMacros.App4\\Profiles\\";
        OutputDirectory = $"{BaseEntityClassName}\\";
        
        //note if we want to map any navigation properties to valueobjects see the example in RecordTypeGenerator.cs
        //this should help with doing 
        // CreateMap<FoodComboViewModel, CreateFoodComboDto>().ForMember(m=>m.FoodComboAmounts,
        //     opt=>opt.MapFrom(src=>src.FoodAmounts));
        switch (viewModelMappingProfileType)
        {
            case ViewModelMappingProfileType.Update:
            case ViewModelMappingProfileType.Create:
                MappingProfileMethodString.Append($@"
                public class {viewModelMappingProfileType.ToString()}{BaseEntityClassName}MappingProfile(){{
                    public {viewModelMappingProfileType.ToString()}{BaseEntityClassName}MappingProfile()
                    {{
                        CreateMap<{viewModelMappingProfileType.ToString()}{BaseEntityClassName}ViewModel, {viewModelMappingProfileType.ToString()}{BaseEntityClassName}Dto>();
                    }}
                ");
                break;
            case ViewModelMappingProfileType.Get:
                MappingProfileMethodString.Append($@"
                public class {viewModelMappingProfileType.ToString()}{BaseEntityClassName}MappingProfile(){{
                    public {viewModelMappingProfileType.ToString()}{BaseEntityClassName}MappingProfile()
                    {{
                        CreateMap<{viewModelMappingProfileType}{BaseEntityClassName}Dto, {viewModelMappingProfileType.ToString()}{BaseEntityClassName}ViewModel>();
                    }}
                ");
                break;
        }
    }


    protected override string BaseTypeString =>
        $"Profile";


    protected override string TargetClassName => $"{_viewModelMappingProfileType.ToString()}{BaseEntityClassName}MappingProfile";


    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        var directives = new[]
        {
            UsingDirective(ParseName(UsingStrings.Automapper)),
            UsingDirective(ParseName($"{UsingStrings.Dtos}.{baseEntityName}")),
            UsingDirective(ParseName(UsingStrings.ViewModels))
        };



        return directives;
    }

    public enum ViewModelMappingProfileType
    {
        Create,
        Update,
        Get
    }
}