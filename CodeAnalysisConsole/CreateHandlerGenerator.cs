using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class CreateHandlerGenerator : HandlerClassGenerator
{
    public CreateHandlerGenerator(ClassDeclarationSyntax classDeclarationSyntax) :
        base(classDeclarationSyntax, HandlerType.Create)
    {
        BaseDirectory =
            "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.Application\\Features\\";
        OutputDirectory = $"{BaseEntityClassName}\\commands\\Create\\";


        HandlerMethodString.Append(
            $@"public class Test{{
                    public async Task<Result<Guid>> Handle(Create{BaseEntityClassName}Command request, CancellationToken cancellationToken)
                    {{
                        var validator = new Create{BaseEntityClassName}CommandValidator();
                        var validationResult = await validator.ValidateAsync(request);

                        if (validationResult.Errors.Count > 0)
                            return new ValidationErrorResult<Guid>(validationResult);
                        
                        var entity = _mapper.Map<Domain.Aggregates.{BaseEntityClassName}.{BaseEntityClassName}>(request);
                        
                        entity = await _{BaseEntityClassNameInCamelCase}Repository.AddAsync(entity);
                        
                        return new SuccessResult<Guid>(entity.Id);
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