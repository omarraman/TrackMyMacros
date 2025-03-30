using System.Text;
using CodeAnalysisConsole;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class MappingProfileGenerator : Generator
{
    private MappingProfileType _mappingProfileType;
    private List<ClassDeclarationSyntax> _valueObjects;
    private Maybe<string> _rootAggregateClassName;
    private bool _isChild;
    private StringBuilder MappingProfileMethodString { get; set; } = new StringBuilder();

    public static MappingProfileGenerator CreateMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax, List<ClassDeclarationSyntax> valueObjects, 
        Maybe<string> rootAggregateClassName,bool isChild)
    {
        return new MappingProfileGenerator(classDeclarationSyntax, MappingProfileType.Create, valueObjects, rootAggregateClassName, isChild);
    }
    public static MappingProfileGenerator UpdateMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax, List<ClassDeclarationSyntax> valueObjects
        , Maybe<string> rootAggregateClassName,bool isChild)
    {
        return new MappingProfileGenerator(classDeclarationSyntax, MappingProfileType.Update, valueObjects, rootAggregateClassName,isChild);
    }
    public static MappingProfileGenerator GetMappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax, List<ClassDeclarationSyntax> valueObjects,
        Maybe<string> rootAggregateClassName,bool isChild)
    {
        return new MappingProfileGenerator(classDeclarationSyntax, MappingProfileType.Get, valueObjects, rootAggregateClassName,isChild);
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

    private (string propertyIdentifier, string Text) GetChildValueObjectName(ClassDeclarationSyntax classDeclarationSyntax, List<ClassDeclarationSyntax> valueObjects)
    {
        var propertiesMembersThatSatisfyPredicate = classDeclarationSyntax.Members
            .Where(m => m is PropertyDeclarationSyntax)
            .ToList();
        var newList = new List<MemberDeclarationSyntax>();
        foreach (var memberDeclarationSyntax in propertiesMembersThatSatisfyPredicate)
        {
            var propertyMember = (PropertyDeclarationSyntax) memberDeclarationSyntax;
            var potentialCollectionTypeContainingValueObject = propertyMember.Type;
            //if we have a property that contains the entity name eg List<RecipeFoodAmounts> when the entity is called Recipe
            if (potentialCollectionTypeContainingValueObject.ToString().Contains(BaseEntityClassName))
            {
                var propertyIdentifier= propertyMember.Identifier.Text;
                //identify the type argument eg RecipeFoodAmounts
                var typeArgument=((GenericNameSyntax)potentialCollectionTypeContainingValueObject).TypeArgumentList.Arguments;
                var valueObject = valueObjects.First(m => m.Identifier.ValueText==typeArgument.ToString());
                var childPropertyType = valueObject.Identifier.Text;
                return ( propertyIdentifier,childPropertyType);
            }
        }

        return (null,null);
    }
    
    private ClassDeclarationSyntax GetChildValueObject(ClassDeclarationSyntax classDeclarationSyntax, List<ClassDeclarationSyntax> valueObjects)
    {
        var propertiesMembersThatSatisfyPredicate = classDeclarationSyntax.Members
            .Where(m => m is PropertyDeclarationSyntax)
            .ToList();
        var newList = new List<MemberDeclarationSyntax>();
        // foreach (var memberDeclarationSyntax in propertiesMembersThatSatisfyPredicate)
        // {
        //     var propertyMember = (PropertyDeclarationSyntax) memberDeclarationSyntax;
        //     var potentialCollectionTypeContainingValueObject = propertyMember.Type;
        //     //if we have a property that contains the entity name eg List<RecipeFoodAmounts> when the entity is called Recipe
        //     if (potentialCollectionTypeContainingValueObject.ToString().Contains(BaseEntityClassName))
        //     {
        //         var propertyIdentifier= propertyMember.Identifier.Text;
        //         //identify the type argument eg RecipeFoodAmounts
        //         var typeArgument=((GenericNameSyntax)potentialCollectionTypeContainingValueObject).TypeArgumentList.Arguments;
        //         var valueObject = valueObjects.First(m => m.Identifier.ValueText==typeArgument.ToString());
        //         return valueObject;
        //     }
        // }
        
        foreach (var memberDeclarationSyntax in propertiesMembersThatSatisfyPredicate)
        {
            var propertyMember = (PropertyDeclarationSyntax) memberDeclarationSyntax;
            var propertyTypeSyntax = propertyMember.Type;
            if (propertyTypeSyntax is not GenericNameSyntax)
            {
                continue;
            }
            var propertyType=((GenericNameSyntax)propertyTypeSyntax).Identifier.Value; //eg List
            var notList = propertyType.ToString() != "List" && propertyType.ToString() != "IList" &&
                         propertyType.ToString() != "IEnumerable" && propertyType.ToString() != "ICollection" &&
                         propertyType.ToString() != "IReadOnlyCollection" && propertyType.ToString() != "IReadOnlyList";
            
            if (notList)
                continue;
                
            var propertyIdentifier= propertyMember.Identifier.Text;
            //identify the type argument eg RecipeFoodAmounts
            var typeArgument=((GenericNameSyntax)propertyTypeSyntax).TypeArgumentList.Arguments;
            var valueObject = valueObjects.First(m => m.Identifier.ValueText==typeArgument.ToString());
            return valueObject;

        }

        return null;
    }

    
    
    
    

    private MappingProfileGenerator(ClassDeclarationSyntax classDeclarationSyntax, MappingProfileType mappingProfileType
         , List<ClassDeclarationSyntax> valueObjects, Maybe<string> rootAggregateClassName,bool isChild
    )
        : base(
            classDeclarationSyntax)
    {
        _isChild = isChild;
        _rootAggregateClassName = rootAggregateClassName==Maybe<string>.None?BaseEntityClassName:rootAggregateClassName;
        _valueObjects = valueObjects;
        _mappingProfileType = mappingProfileType;
        BaseDirectory =
            $"{Constants.RootDirectory}RiderProjects\\TrackMyMacros\\TrackMyMacros.Application\\Profiles\\";
        OutputDirectory = $"{BaseEntityClassName}\\";
        // (string propertyIdentifier, string Text) childProperties = GetChildValueObjectName(classDeclarationSyntax, valueObjects);
        var childValueObject = GetChildValueObject(classDeclarationSyntax, valueObjects);
        switch (mappingProfileType)
        {
            case MappingProfileType.Update:
            case MappingProfileType.Create:
                string navigationProperty="";
                string dtoChildMapping = string.Empty;
                string commandChildMapping = string.Empty;
                // if (!string.IsNullOrEmpty(childProperties.propertyIdentifier))
                // {
                //     CreateMappingProfileGenerator()
                //     navigationProperty = @$".ForMember(m=>m.{childProperties.propertyIdentifier}, opt
                //     =>opt.MapFrom(src=>src.{childProperties.propertyIdentifier}));";
                //
                //     dtoChildMapping = $"CreateMap<{mappingProfileType.ToString()}{childProperties.Text}Dto, {mappingProfileType.ToString()}{childProperties.Text}>();";
                //     commandChildMapping = $"CreateMap<{mappingProfileType.ToString()}{childProperties.Text}, {childProperties.Text}>();";
                // }

                if (childValueObject!=null)
                {
                        CreateMappingProfileGenerator(childValueObject,  valueObjects,_rootAggregateClassName,true).GenerateAndWriteClass2();
                }

                MappingProfileMethodString.Append($@"
                    public class {mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile(){{
                        public {mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile()
                        {{
                            CreateMap<{mappingProfileType.ToString()}{BaseEntityClassName}Dto, {mappingProfileType.ToString()}{BaseEntityClassName}Command>();
                            {dtoChildMapping}
                            CreateMap<{mappingProfileType.ToString()}{BaseEntityClassName}Command, Domain.Aggregates.{BaseEntityClassName}.{BaseEntityClassName}>();
                            {commandChildMapping}
                    }}
                ");
                break;
            case MappingProfileType.Get:
                string getDtoChildMapping = string.Empty;

                // if (!string.IsNullOrEmpty(childProperties.propertyIdentifier))
                // {
                //     getDtoChildMapping = $"CreateMap<{childProperties.Text}, {mappingProfileType.ToString()}{childProperties.Text}Dto>();";
                // }
                
                if (childValueObject!=null)
                {
                    GetMappingProfileGenerator(childValueObject,  valueObjects,_rootAggregateClassName,true).GenerateAndWriteClass2();
                }
                MappingProfileMethodString.Append($@"
public class {mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile(){{
    public {mappingProfileType.ToString()}{BaseEntityClassName}MappingProfile()
    {{
        CreateMap<{GetFullyQualifiedNamespace}.{BaseEntityClassName}, {mappingProfileType.ToString()}{BaseEntityClassName}Dto>();
        {getDtoChildMapping}
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
            UsingDirective(ParseName($"{GetFullyQualifiedNamespace}"))
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

    public string GetFullyQualifiedNamespace {
        get
        {
            var immediateRoot = BaseEntityClassName;

            if (_isChild)
            {
                immediateRoot = _rootAggregateClassName.Value;
            }

            return UsingStrings.Aggregates + "." + immediateRoot ;}
        }
    //at the top level we want baseentity class name
    //but when it is a child we want the root agg

    public enum MappingProfileType
    {
        Create,
        Update,
        Get
    }
}