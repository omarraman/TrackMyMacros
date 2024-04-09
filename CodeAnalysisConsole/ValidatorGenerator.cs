using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Infrastructure;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class ValidatorGenerator : Generator
{
    private ValidatorType _validatorType;
    private StringBuilder ValidatiorMethodString { get; set; } = new StringBuilder();

    public static ValidatorGenerator CreateValidatorGenerator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        return new ValidatorGenerator(classDeclarationSyntax, ValidatorType.Create);
    }

    public static ValidatorGenerator UpdateValidatorGenerator(ClassDeclarationSyntax classDeclarationSyntax)
    {
        return new ValidatorGenerator(classDeclarationSyntax, ValidatorType.Update);
    }


    protected override Maybe<ConstructorDeclarationSyntax> ConstructorDeclarationSyntax
    {
        get
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(ValidatiorMethodString.ToString());
            var constructorDeclarationSyntax = tree.GetCompilationUnitRoot().DescendantNodes()
                .OfType<ConstructorDeclarationSyntax>().First();
            return constructorDeclarationSyntax;
        }
    }


    // public ConstructorDeclarationSyntax GetConstructor()
    // {
    //     SyntaxTree tree = CSharpSyntaxTree.ParseText(ValidatiorMethodString.ToString());
    //     var constructorDeclarationSyntax = tree.GetCompilationUnitRoot().DescendantNodes()
    //         .OfType<ConstructorDeclarationSyntax>().First();
    //     return constructorDeclarationSyntax;
    // }

    // protected override ClassDeclarationSyntax GenerateClassDeclarationSyntax2(ClassDeclarationSyntax classDeclaration,
    //     string identifier) =>
    //     base.GenerateClassDeclarationSyntax2(classDeclaration)
    //         .AddBaseListTypes(SimpleBaseType(ParseTypeName(BaseTypeString)))
    //         .AddMembers(GetConstructor());


    public ValidatorGenerator(ClassDeclarationSyntax classDeclarationSyntax, ValidatorType validatorType) : base(
        classDeclarationSyntax)
    {
        _validatorType = validatorType;
//         ValidatiorMethodString.Append($@"
// public class {validatorType.ToString()}{BaseEntityClassName}Validator(){{
//     public {validatorType.ToString()}{BaseEntityClassName}Validator()
//     {{
//         RuleFor(p => p.Name)
//             .NotEmpty().WithMessage(""{{PropertyName}} is required"")
//             .NotNull();
//     }}
// }}
// ");


        try
        {
            ValidatiorMethodString.Append($@"
public class {validatorType.ToString()}{BaseEntityClassName}Validator(){{
    public {validatorType.ToString()}{BaseEntityClassName}Validator()
    {{
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage(""{{PropertyName}} is required"")
            .NotNull();
");

            if (validatorType == ValidatorType.Update)
            {
                ValidatiorMethodString.Append($@"
            RuleFor(p => p.Id)
            .NotEmpty().WithMessage(""{{PropertyName}} is required"")
            .NotNull();
            ");
            }

            ValidatiorMethodString.Append($@"
    }}
}}
");

            // BaseTypeString = $"AbstractValidator<{validatorType.ToString()}{BaseEntityClassName}Command>";
            // TargetClassName = $"{validatorType.ToString()}{BaseEntityClassName}Validator";

            // if (validatorType == ValidatorType.Update)
            // {
            //     Console.WriteLine("Update");
            //     Console.WriteLine(ValidatiorMethodString);
            //     Console.WriteLine("Basetypestring");
            //     Console.WriteLine(BaseTypeString);
            //     Console.WriteLine("TargetClassName");
            //     Console.WriteLine(TargetClassName);
            // }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected override string BaseTypeString =>
        $"AbstractValidator<{_validatorType.ToString()}{BaseEntityClassName}Command>";


    protected override string TargetClassName => $"{_validatorType.ToString()}{BaseEntityClassName}Validator";
    // public async Task GenerateAndWriteValidatorClass()
    // {
    //     var classDeclarationSyntax = GenerateClassDeclarationSyntax2(ClassDeclaration, TargetClassName);
    //     await WriteClassToFile(classDeclarationSyntax,
    //         GetUsingNamespaces(BaseEntityClassName),
    //         TargetClassName);
    // }


    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        var directives = new[]
        {
            UsingDirective(ParseName(UsingStrings.FluentValidation))
        };
        return directives;
    }

    public enum ValidatorType
    {
        Create,
        Update
    }
}