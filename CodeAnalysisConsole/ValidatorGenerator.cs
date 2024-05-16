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

    public ValidatorGenerator(ClassDeclarationSyntax classDeclarationSyntax, ValidatorType validatorType) : base(
        classDeclarationSyntax)
    {
        BaseDirectory =
            "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.Application\\Features\\";
        OutputDirectory = $"{BaseEntityClassName}\\Commands\\{validatorType.ToString()}\\";
        _validatorType = validatorType;
        try
        {
            ValidatiorMethodString.Append($@"
public class {validatorType.ToString()}{BaseEntityClassName}CommandValidator(){{
    public {validatorType.ToString()}{BaseEntityClassName}CommandValidator()
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
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected override string BaseTypeString =>
        $"AbstractValidator<{_validatorType.ToString()}{BaseEntityClassName}Command>";


    protected override string TargetClassName => $"{_validatorType.ToString()}{BaseEntityClassName}CommandValidator";


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