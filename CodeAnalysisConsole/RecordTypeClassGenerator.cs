using Microsoft.CodeAnalysis;
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
                var collectionTypeContainingValueObject = propertyMember.Type;
                
                if (collectionTypeContainingValueObject.ToString().Contains(BaseEntityClassName))
                {
                    
                    var collectionTypeIdentifier=((GenericNameSyntax)collectionTypeContainingValueObject).Identifier.Value; //eg List

                    var typeArgument=((GenericNameSyntax)collectionTypeContainingValueObject).TypeArgumentList.Arguments;
                    var valueObject = _valueObjects.First(m => m.Identifier.ValueText==typeArgument.ToString());
                    var replacementTypeArgument = GetNewTypeArgumentName(typeArgument);
                    var newType = ParseTypeName(GetNewContainedTypeName(collectionTypeIdentifier, replacementTypeArgument));
                    newList.Add(propertyMember.WithType(newType));
                    newList.Add(GenerateNewClassDeclaration(valueObject, replacementTypeArgument, m => m is PropertyDeclarationSyntax, []));

                }
                else
                {
                    newList.Add(propertyMember);
                
                }
            }
            
            return newList;
        }
    }
}