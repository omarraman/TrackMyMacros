﻿using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class DeleteHandlerGenerator : HandlerClassGenerator
{
    public DeleteHandlerGenerator(ClassDeclarationSyntax classDeclarationSyntax) : base(classDeclarationSyntax)
    {
        HandlerMethodString.Append("public class Test{    " +
                  $@"public async Task<Result> Handle(Delete{BaseEntityClassName}Command request, CancellationToken cancellationToken)
                    {{
                        await _{BaseEntityClassNameInCamelCase}Repository.DeleteAsync(request.Id);
                        return new SuccessResult();
                    }}" +
                  "}");
        
                _baseTypeString= $"IRequestHandler<{CommandOrQueryIdentifier.Delete(BaseEntityClassName)},Result>";        
                HandlerName= CommandOrQueryHandlerIdentifier.Delete(BaseEntityClassName);
                TargetClassName = CommandOrQueryHandlerIdentifier.Delete(BaseEntityClassName);
    }
    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        var directives = new[]
        {
            UsingDirective(ParseName(UsingStrings.Persistance)),
        };
        return base.GetUsingNamespaces(baseEntityName).Union(directives).ToArray();
    }

}