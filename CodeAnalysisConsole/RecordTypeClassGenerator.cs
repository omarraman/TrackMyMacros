using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace CodeGen;

public abstract class RecordTypeClassGenerator:Generator
{
    protected bool ShouldIncludeMember(PropertyDeclarationSyntax propertyDeclaration,
        Func<PropertyDeclarationSyntax, bool> predicate) =>
        propertyDeclaration.AttributeLists.All(
            a => a.Attributes.All(
                attr => attr.Name.ToString() != "CodeGenIgnoreMember")) && predicate(propertyDeclaration);
    
    protected Func<PropertyDeclarationSyntax, bool> _everythingApartFromIdPredicate = syntax => syntax.Identifier.Text != "Id";
    protected Func<PropertyDeclarationSyntax, bool> _onlyIdPredicate = syntax => syntax.Identifier.Text == "Id";
    protected Func<PropertyDeclarationSyntax, bool> _allMembersPredicate = syntax => true;
    private List<ClassDeclarationSyntax> _valueObjects;

    protected Func<PropertyDeclarationSyntax, bool> MemberSelectionPredicate { get; set; } = p => true;

    public RecordTypeClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) : base(classDeclarationSyntax)
    {
        _valueObjects = valueObjects;
    }
    
    protected virtual  string GetNewContainedTypeName(object? collectionTypeIdentifier, string replacementTypeArgument)
    {
        throw new System.NotImplementedException();

    }

    protected virtual string GetNewTypeArgumentName(SeparatedSyntaxList<TypeSyntax> typeArgument)
    {
        throw new System.NotImplementedException();
    }
    protected override List<MemberDeclarationSyntax> MemberDeclarationSyntaxes {
        get
        {
            ///select all members from _classDeclarationSyntax that are properties
            var propertiesMembersThatSatisfyPredicate =  ClassDeclaration.Members
                .Where(m => m is PropertyDeclarationSyntax)
                .Where(m=>ShouldIncludeMember((PropertyDeclarationSyntax)m, MemberSelectionPredicate))
                .ToList();

            var newList = new List<MemberDeclarationSyntax>();
            foreach (var memberDeclarationSyntax in propertiesMembersThatSatisfyPredicate)
            {
                var propertyMember = (PropertyDeclarationSyntax) memberDeclarationSyntax;
                var propertyTypeSyntax = propertyMember.Type;
                if (propertyTypeSyntax is not GenericNameSyntax)
                {
                    newList.Add(propertyMember);
                    continue;
                }
                var propertyType=((GenericNameSyntax)propertyTypeSyntax).Identifier.Value; //eg List
                Debug.WriteLine(propertyType.ToString());

                if (propertyType.ToString()!="List" && propertyType.ToString()!="IList" && propertyType.ToString()!="IEnumerable" && propertyType.ToString()!="ICollection" && propertyType.ToString()!="IReadOnlyCollection" && propertyType.ToString()!="IReadOnlyList")
                {
                    newList.Add(propertyMember);
                }
                
                ReplaceValueObjectWithChildDto(propertyTypeSyntax, propertyType.ToString(), propertyMember, newList);

            }
            
            return newList;
        }
    }


    private async Task ReplaceValueObjectWithChildDto(TypeSyntax propertyTypeSyntax,string propertyType, PropertyDeclarationSyntax propertyMember, List<MemberDeclarationSyntax> newList)
    {
        var typeArgument=((GenericNameSyntax)propertyTypeSyntax).TypeArgumentList.Arguments;
        var valueObject = _valueObjects.First(m => m.Identifier.ValueText==typeArgument.ToString());
                    
        //generate the new type argument name eg CreateRecipeFoodAmountsDto
        var replacementTypeArgument = GetNewTypeArgumentName(typeArgument);
        var newType = ParseTypeName(GetNewContainedTypeName(propertyType, replacementTypeArgument));
        //add it as a member
        newList.Add(propertyMember.WithType(newType));
        // newList.Add(GenerateNewClassDeclaration(valueObject, replacementTypeArgument, m => m is PropertyDeclarationSyntax p && p.Identifier.Text !="Id", []));

        GenerateChildForValueObject(valueObject,_valueObjects); //create new class eg dto for the value object

        //creates something like this
        //GetMesocycleWeekDto is added to the list of members
//         
//     public class GetMesocycleDto
//     {
//         public Guid Id { get; set; }
//         public string Name { get; set; }
//         public List<GetMesocycleWeekDto> MesocycleWeeks { get; set; }
//
//         public class GetMesocycleWeekDto
//         {
//             public int WeekIndex { get; init; }
//             
//         }
//     }
// }
        
    }
    
    protected abstract Task GenerateChildForValueObject(ClassDeclarationSyntax valueObject,List<ClassDeclarationSyntax> valueObjects);

    private ClassDeclarationSyntax GenerateNewClassDeclaration(ClassDeclarationSyntax classDeclaration,
        string identifier, Func<MemberDeclarationSyntax, bool> predicate, BaseTypeSyntax[] baseTypes)
    {
        
        
        var membersToAdd = classDeclaration.Members.Where(m => predicate(m)).ToArray();

        return ClassDeclaration(Identifier(identifier))
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            // .AddBaseListTypes(baseTypes)
            .AddMembers(membersToAdd);
    }
}