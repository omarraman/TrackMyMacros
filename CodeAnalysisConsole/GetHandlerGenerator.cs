using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class GetHandlerGenerator : HandlerClassGenerator
{
    public GetHandlerGenerator(ClassDeclarationSyntax classDeclarationSyntax) : base(classDeclarationSyntax)
    {
        HandlerMethodString.Append("public class Test{    " +
                  $"public async Task<Maybe<{DtoIdentifier.Get(BaseEntityClassName)}>> Handle({CommandOrQueryIdentifier.Get(BaseEntityClassName)} request, CancellationToken cancellationToken)" +
                  "{    " +
                  $"       var results = await _{System.Text.Json.JsonNamingPolicy.CamelCase.ConvertName(BaseEntityClassName)}Repository.GetByIdAsync(request.Id);" +
                  $"     var mapped = results.HasValue? _mapper.Map<{DtoIdentifier.Get(BaseEntityClassName)}>(results.Value):Maybe<{DtoIdentifier.Get(BaseEntityClassName)}>.None;" +
                  "        return mapped;    }" +
                  "}");
        
                _baseTypeString= $"IRequestHandler<{CommandOrQueryIdentifier.Get(BaseEntityClassName)},Maybe<{DtoIdentifier.Get(BaseEntityClassName)}>>";        
                HandlerName= CommandOrQueryHandlerIdentifier.Get(BaseEntityClassName);
                TargetClassName = CommandOrQueryHandlerIdentifier.Create(BaseEntityClassName);
    }
    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        var directives = new[]
        {
            UsingDirective(ParseName(UsingStrings.Infrastructure)),
            UsingDirective(ParseName(UsingStrings.Application)),
            UsingDirective(ParseName(UsingStrings.Dtos)),
            UsingDirective(ParseName(UsingStrings.Persistance)),
            UsingDirective(ParseName($"TrackMyMacros.Dtos.{baseEntityName}")),
        };
        return base.GetUsingNamespaces(baseEntityName).Union(directives).ToArray();
    }

}