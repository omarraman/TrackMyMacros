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
    private ClassDeclarationSyntax _classDeclarationSyntax;

    public static DtoClassGenerator CreateDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Create);
    
    public static DtoClassGenerator GetDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Get);
    
    public static DtoClassGenerator UpdateDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Update);
    
    public static DtoClassGenerator DeleteDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Delete);

    protected override List<MemberDeclarationSyntax> MemberDeclarationSyntaxes {
        get
        {
            return _classDeclarationSyntax.Members.Where(m => ShouldIncludeMember((PropertyDeclarationSyntax)m,
                MemberSelectionPredicate)).ToList();
        }
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

    private DtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax, DtoType dtoType) : base(classDeclarationSyntax)
    {
        _classDeclarationSyntax = classDeclarationSyntax;
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
    
    // Func<PropertyDeclarationSyntax, bool> _everythingApartFromIdPredicate = syntax => syntax.Identifier.Text != "Id";
    // Func<PropertyDeclarationSyntax, bool> _onlyIdPredicate = syntax => syntax.Identifier.Text == "Id";
    // Func<PropertyDeclarationSyntax, bool> _allMembersPredicate = syntax => true;
    //
    // protected Func<PropertyDeclarationSyntax, bool> MemberSelectionPredicate { get; set; } = p => true;
    protected virtual UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return [];
    }

    // protected ClassDeclarationSyntax GenerateClassDeclarationSyntax(ClassDeclarationSyntax classDeclaration, string identifier) =>
    //     ClassDeclaration(Identifier(identifier))
    //         .AddModifiers(Token(SyntaxKind.PublicKeyword))
    //         .AddMembers(classDeclaration.Members.Where(m => ShouldIncludeMember((PropertyDeclarationSyntax)m,
    //             MemberSelectionPredicate
    //         )).ToArray());

    // static bool ShouldIncludeMember(PropertyDeclarationSyntax propertyDeclaration,
    //     Func<PropertyDeclarationSyntax, bool> predicate) =>
    //     propertyDeclaration.AttributeLists.All(
    //         a => a.Attributes.All(
    //             attr => attr.Name.ToString() != "CodeGenIgnoreMember")) && predicate(propertyDeclaration);
    // public async  Task GenerateAndWriteCommandOrQueryDtoClass()
    // {
    //     var classDeclarationSyntax = GenerateClassDeclarationSyntax(ClassDeclaration, TargetClassName);
    //     await WriteClassToFile(classDeclarationSyntax,            GetUsingNamespaces(BaseEntityClassName), TargetClassName);
    // }



}
 
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
    
    protected Func<PropertyDeclarationSyntax, bool> MemberSelectionPredicate { get; set; } = p => true;

    public RecordTypeClassGenerator(ClassDeclarationSyntax classDeclarationSyntax) : base(classDeclarationSyntax)
    {
        
    }

}