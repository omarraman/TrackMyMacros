using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Infrastructure;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class CommandOrQueryGenerator : RecordTypeClassGenerator
{
    private CommandOrQueryType _commandOrQueryType;
    private List<ClassDeclarationSyntax> _valueObjects;

    public static CommandOrQueryGenerator CreateCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.Create, valueObjects );
    
    public static CommandOrQueryGenerator GetCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.Get,valueObjects);
    
    public static CommandOrQueryGenerator GetListCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.GetList,valueObjects);
    
    public static CommandOrQueryGenerator UpdateCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.Update,valueObjects);
    
    public static CommandOrQueryGenerator DeleteCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.Delete,valueObjects);

    protected override async Task GenerateChildForValueObject(ClassDeclarationSyntax valueObject,List<ClassDeclarationSyntax> valueObjects)
    {
        switch (_commandOrQueryType)
        {
            case CommandOrQueryType.Create:
                await CreateCommandOrQueryGenerator(valueObject,valueObjects).GenerateAndWriteClass2();
                break;
            case CommandOrQueryType.Update:
                await UpdateCommandOrQueryGenerator(valueObject,valueObjects).GenerateAndWriteClass2();
                break;
            case CommandOrQueryType.Get:
                await GetCommandOrQueryGenerator(valueObject,valueObjects).GenerateAndWriteClass2();
                break;
            case CommandOrQueryType.GetList:
                await GetListCommandOrQueryGenerator(valueObject,valueObjects).GenerateAndWriteClass2();
                break;
            case CommandOrQueryType.Delete:
                await DeleteCommandOrQueryGenerator(valueObject,valueObjects).GenerateAndWriteClass2();
                break;
        }
    }

    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        if (!_commandOrQueryType.ToString().StartsWith("Get"))
            return base.GetUsingNamespaces(baseEntityName);
        
        
        var directives = new[]
        {
            UsingDirective(ParseName($"{UsingStrings.Dtos}.{BaseEntityClassName}")),
        };
        if (_commandOrQueryType == CommandOrQueryType.Get)
        {
            directives=directives.Append(UsingDirective(ParseName(UsingStrings.Infrastructure))).ToArray();
        }


        return base.GetUsingNamespaces(baseEntityName).Union(directives).ToArray();
    }
    
    protected override string BaseTypeString {
        get
        {
            switch (_commandOrQueryType)
            {
                case CommandOrQueryType.Create:
                    return "RequestBase<Result<Guid>>";
                case CommandOrQueryType.Update:
                    return "RequestBase<Result>";
                case CommandOrQueryType.Get:
                    return $"RequestBase<Maybe<{DtoIdentifier.Get(BaseEntityClassName)}>>";
                case CommandOrQueryType.Delete:
                    return "RequestBase<Result>";
                case CommandOrQueryType.GetList:
                    return $"RequestBase<IReadOnlyList<{DtoIdentifier.Get(BaseEntityClassName)}>>";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
    protected override string TargetClassName {
        get
        {
            switch (_commandOrQueryType)
            {
                case CommandOrQueryType.Create:
                    return CommandOrQueryIdentifier.Create(BaseEntityClassName);
                case CommandOrQueryType.Update:
                    return CommandOrQueryIdentifier.Update(BaseEntityClassName);
                case CommandOrQueryType.Get:
                    return CommandOrQueryIdentifier.Get(BaseEntityClassName);
                case CommandOrQueryType.Delete:
                    return CommandOrQueryIdentifier.Delete(BaseEntityClassName);
                case CommandOrQueryType.GetList:
                    return CommandOrQueryIdentifier.GetList(BaseEntityClassName);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        
        }
    }


    private CommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax, CommandOrQueryType commandOrQueryType
        ,List<ClassDeclarationSyntax> valueObjects
        ) : base(classDeclarationSyntax,valueObjects)
    {
        _valueObjects = valueObjects;
        _commandOrQueryType = commandOrQueryType;
        
        BaseDirectory =
            "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.Application\\Features\\";
        var subDir = _commandOrQueryType.ToString().StartsWith("Get")?"Queries":"Commands";
        OutputDirectory = $"{BaseEntityClassName}\\{subDir}\\{_commandOrQueryType.ToString()}\\";

        switch (commandOrQueryType)
        {
            case CommandOrQueryType.Create:
                MemberSelectionPredicate = _everythingApartFromIdPredicate;
                break;
            case CommandOrQueryType.Update:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case CommandOrQueryType.Get:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case CommandOrQueryType.Delete:
                MemberSelectionPredicate = _onlyIdPredicate;
                break;
            case CommandOrQueryType.GetList:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
        }
    }
    
    public enum CommandOrQueryType
    {
        Create,
        Update,
        Get,
        GetList,
        Delete
    }
    
    // protected override List<MemberDeclarationSyntax> MemberDeclarationSyntaxes {
    //     get
    //     {
    //         ///select all members from _classDeclarationSyntax that are properties
    //         var propertiesMembersThatSatisfyPredicate =  ClassDeclaration.Members
    //             .Where(m => m is PropertyDeclarationSyntax)
    //             .Where(m=>ShouldIncludeMember((PropertyDeclarationSyntax)m, MemberSelectionPredicate))
    //             .ToList();
    //
    //         var newList = new List<MemberDeclarationSyntax>();
    //         foreach (var memberDeclarationSyntax in propertiesMembersThatSatisfyPredicate)
    //         {
    //             var propertyMember = (PropertyDeclarationSyntax) memberDeclarationSyntax;
    //             var collectionTypeContainingValueObject = propertyMember.Type;
    //             
    //             if (collectionTypeContainingValueObject.ToString().Contains(BaseEntityClassName))
    //             {
    //                 
    //                 var collectionTypeIdentifier=((GenericNameSyntax)collectionTypeContainingValueObject).Identifier.Value; //eg List
    //
    //                 var typeArgument=((GenericNameSyntax)collectionTypeContainingValueObject).TypeArgumentList.Arguments;
    //                 var valueObject = _valueObjects.First(m => m.Identifier.ValueText==typeArgument.ToString());
    //                 var replacementTypeArgument = GetNewTypeArgumentName(typeArgument);
    //                 var newType = ParseTypeName(GetNewContainedTypeName(collectionTypeIdentifier, replacementTypeArgument));
    //                 newList.Add(propertyMember.WithType(newType));
    //                 newList.Add(GenerateNewClassDeclaration(valueObject, $"{_commandOrQueryType}{valueObject.Identifier}",
    //                     m => m is PropertyDeclarationSyntax));
    //
    //             }
    //             else
    //             {
    //                 newList.Add(propertyMember);
    //             
    //             }
    //         }
    //         
    //         return newList;
    //     }
    // }

    protected override string GetNewContainedTypeName(object? collectionTypeIdentifier, string replacementTypeArgument)
    {
        return $"{collectionTypeIdentifier}<{replacementTypeArgument}>";
    }

    protected override string GetNewTypeArgumentName(SeparatedSyntaxList<TypeSyntax> typeArgument)
    {
        return $"{_commandOrQueryType}{typeArgument}";
    }
}