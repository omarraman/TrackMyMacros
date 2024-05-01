using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class GetListHandlerGenerator : HandlerClassGenerator
{
    public GetListHandlerGenerator(ClassDeclarationSyntax classDeclarationSyntax) : base(classDeclarationSyntax, 
         HandlerType.GetList)
    {
        BaseDirectory= "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.Application\\Features\\";
        OutputDirectory= $"{BaseEntityClassName}\\queries\\Get\\";
        HandlerMethodString.Append("public class Test{    " +
                  $"public async Task<IReadOnlyList<{DtoIdentifier.Get(BaseEntityClassName)}>> Handle({CommandOrQueryIdentifier.GetList(BaseEntityClassName)} request, CancellationToken cancellationToken)" +
                  "{    " +
                  $"       var results = await _{BaseEntityClassNameInCamelCase}Repository.ListAllAsync();" +
                  $"     var mapped = _mapper.Map<IReadOnlyList<{DtoIdentifier.Get(BaseEntityClassName)}>>(results);" +
                  "        return mapped;    }" +
                  "}");
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