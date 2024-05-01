using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class DtoClassGenerator : RecordTypeClassGenerator
{
    private DtoType _dtoType;
    // private ClassDeclarationSyntax _classDeclarationSyntax;

    public static DtoClassGenerator CreateDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Create,valueObjects);
    
    public static DtoClassGenerator GetDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Get,valueObjects);
    
    public static DtoClassGenerator UpdateDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Update,valueObjects);
    
    public static DtoClassGenerator DeleteDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Delete,valueObjects);

    // protected override List<MemberDeclarationSyntax> MemberDeclarationSyntaxes {
    //     get
    //     {
    //         ///select all members from _classDeclarationSyntax that are properties
    //         var x =  ClassDeclaration.Members
    //             .Where(m => m is PropertyDeclarationSyntax)
    //             .Where(m=>ShouldIncludeMember((PropertyDeclarationSyntax)m, MemberSelectionPredicate))
    //             .ToList();
    //
    //         var newList = new List<MemberDeclarationSyntax>();
    //         foreach (var memberDeclarationSyntax in x)
    //         {
    //             var y = (PropertyDeclarationSyntax) memberDeclarationSyntax;
    //             var z = y.Type;
    //             if (z.ToString().Contains(BaseEntityClassName))
    //             {
    //                 var containedType=((GenericNameSyntax)z).TypeArgumentList.Arguments;
    //                 //containedType will be FoodComboAmount
    //                 //we want to replace FoodComboAmount with GetFoodComboAmountDto
    //                 var replacement = $"{_dtoType}{containedType}Dto"; 
    //                 var newType = ParseTypeName(replacement);
    //                 //change the type of the property to the new type
    //                 //add y but with the new type to the new list
    //                 // var p = y.WithType(newType);
    //                 newList.Add(y.WithType(newType));
    //                 
    //             }
    //             else
    //             {
    //                 newList.Add(y);
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
        return $"{_dtoType}{typeArgument}Dto";
    }
    
    protected override string TargetClassName
    {
        get
        {
            switch (_dtoType)
            {
                case DtoType.Create:
                    return DtoIdentifier.Create(BaseEntityClassName);
                case DtoType.Update:
                    return DtoIdentifier.Update(BaseEntityClassName);
                case DtoType.Get:
                    return DtoIdentifier.Get(BaseEntityClassName);
                case DtoType.Delete:
                    return DtoIdentifier.Delete(BaseEntityClassName);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private DtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax, DtoType dtoType,List<ClassDeclarationSyntax> valueObjects) 
        : base(classDeclarationSyntax,valueObjects)
    {
        // _classDeclarationSyntax = classDeclarationSyntax;
        BaseDirectory= "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.Dtos\\";
        OutputDirectory= BaseEntityClassName;

        _dtoType = dtoType;
        switch (dtoType)
        {
            case DtoType.Create:
                MemberSelectionPredicate = _everythingApartFromIdPredicate;
                break;
            case DtoType.Update:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case DtoType.Get:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case DtoType.Delete:
                MemberSelectionPredicate = _onlyIdPredicate;
                break;
        }
    }

    private enum DtoType
    {
        Create,
        Update,
        Get,
        Delete
    }
}