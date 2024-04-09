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

    public static CommandOrQueryGenerator CreateCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.Create);
    
    public static CommandOrQueryGenerator GetCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.Get);
    
    public static CommandOrQueryGenerator GetListCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.GetList);
    
    public static CommandOrQueryGenerator UpdateCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.Update);
    
    public static CommandOrQueryGenerator DeleteCommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax) =>
        new CommandOrQueryGenerator(classDeclarationSyntax, CommandOrQueryType.Delete);


    protected override string BaseTypeString {
        get
        {
            switch (_commandOrQueryType)
            {
                case CommandOrQueryType.Create:
                    return "RequestBase<Result<int>>";
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
    protected override List<FieldDeclarationSyntax> FieldDeclarationSyntaxList { get; }
    protected override Maybe<ConstructorDeclarationSyntax> ConstructorDeclarationSyntax { get; }
    protected override List<MethodDeclarationSyntax> MethodDeclarationSyntax { get; }

    private CommandOrQueryGenerator(ClassDeclarationSyntax classDeclarationSyntax, CommandOrQueryType commandOrQueryType) : base(classDeclarationSyntax)
    {
        _commandOrQueryType = commandOrQueryType;


        switch (commandOrQueryType)
        {
            case CommandOrQueryType.Create:
                // BaseTypeString= "RequestBase<Result<int>>";
                // TargetClassName = CommandOrQueryIdentifier.Create(BaseEntityClassName);
                MemberSelectionPredicate = _everythingApartFromIdPredicate;
                break;
            case CommandOrQueryType.Update:
                // BaseTypeString= "RequestBase<Result>";
                // TargetClassName = CommandOrQueryIdentifier.Update(BaseEntityClassName);
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case CommandOrQueryType.Get:
                // BaseTypeString= $"RequestBase<Maybe<{DtoIdentifier.Get(BaseEntityClassName)}>>";
                // TargetClassName = CommandOrQueryIdentifier.Get(BaseEntityClassName);
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case CommandOrQueryType.Delete:
                // BaseTypeString= "RequestBase<Result>";
                // TargetClassName = CommandOrQueryIdentifier.Delete(BaseEntityClassName);
                MemberSelectionPredicate = _onlyIdPredicate;
                break;
            case CommandOrQueryType.GetList:
                // BaseTypeString= $"RequestBase<IReadOnlyList<{DtoIdentifier.Get(classDeclarationSyntax.Identifier.Text)}>>";
                // TargetClassName = CommandOrQueryIdentifier.GetList(BaseEntityClassName);
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
    
    // Func<PropertyDeclarationSyntax, bool> _everythingApartFromIdPredicate = syntax => syntax.Identifier.Text != "Id";
    // Func<PropertyDeclarationSyntax, bool> _onlyIdPredicate = syntax => syntax.Identifier.Text == "Id";
    // Func<PropertyDeclarationSyntax, bool> _allMembersPredicate = syntax => true;
    
    // protected Func<PropertyDeclarationSyntax, bool> MemberSelectionPredicate { get; set; } = p => true;
    protected virtual UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return [];
    }

    private ClassDeclarationSyntax GenerateClassDeclarationSyntax(ClassDeclarationSyntax classDeclaration, string identifier) =>
        ClassDeclaration(Identifier(identifier))
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            .AddBaseListTypes(GetBaseTypes())
            .AddMembers(classDeclaration.Members.Where(m => ShouldIncludeMember((PropertyDeclarationSyntax)m,
                MemberSelectionPredicate
            )).ToArray());


    public async  Task GenerateAndWriteCommandOrQueryCommandOrQuery()
    {
        var classDeclarationSyntax = GenerateClassDeclarationSyntax(ClassDeclaration, TargetClassName);
        await WriteClassToFile(classDeclarationSyntax,            GetUsingNamespaces(BaseEntityClassName), TargetClassName);
    }



}