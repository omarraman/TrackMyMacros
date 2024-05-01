using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class UpdateHandlerGenerator : HandlerClassGenerator
{
    public UpdateHandlerGenerator(ClassDeclarationSyntax classDeclarationSyntax) : base(classDeclarationSyntax, HandlerType.Update)
    {
        BaseDirectory =
            "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.Application\\Features\\";
        OutputDirectory = $"{BaseEntityClassName}\\Commands\\Update\\";
        HandlerMethodString.Append(
            $@"public class Test{{
                                    public async Task<Result> Handle(Update{BaseEntityClassName}Command request, CancellationToken cancellationToken)
                                    {{
                                        var validator = new Update{BaseEntityClassName}CommandValidator();
                                        var validationResult = await validator.ValidateAsync(request);
                                        
                                        if (validationResult.Errors.Count > 0)
                                            return new ValidationErrorResult(validationResult);
                                        
                                        var {BaseEntityClassNameInCamelCase} = _mapper.Map<Domain.Aggregates.{BaseEntityClassName}.{BaseEntityClassName}>(request);
                                         await _{BaseEntityClassNameInCamelCase}Repository.UpdateAsync({BaseEntityClassNameInCamelCase});
                                        
                                        return new SuccessResult();
                                    }}
            }}");
    }

    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        var directives = new[]
        {
            UsingDirective(ParseName(UsingStrings.Application)),
            UsingDirective(ParseName(UsingStrings.Dtos)),
            UsingDirective(ParseName(UsingStrings.Common)),
            UsingDirective(ParseName(UsingStrings.Persistance)),
        };
        return base.GetUsingNamespaces(baseEntityName).Union(directives).ToArray();
    }


}