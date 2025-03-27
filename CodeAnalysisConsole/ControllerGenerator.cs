using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class ControllerGenerator : Generator
{
    // protected override AttributeListSyntax AttributeListSyntax()=>AttributeList(SingletonSeparatedList(Attribute(IdentifierName("ApiController")), 
    protected override Maybe<AttributeListSyntax> AttributeListSyntax
    {
        get
        {
            var attributeListSyntax = AttributeList(SingletonSeparatedList(Attribute(IdentifierName("ApiController"))));
            attributeListSyntax = attributeListSyntax.AddAttributes(Attribute(IdentifierName("Route")).WithArgumentList(AttributeArgumentList(SingletonSeparatedList(AttributeArgument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal("api/[controller]")))))));
            return attributeListSyntax;
        }

    }
     
    
    // protected override AttributeListSyntax AttributeListSyntax()=>
    // {
    //     var attributeListSyntax = AttributeList(SingletonSeparatedList(Attribute(IdentifierName("ApiController"))));
    //     attributeListSyntax = attributeListSyntax.AddAttributes(Attribute(IdentifierName("Route")).WithArgumentList(AttributeArgumentList(SingletonSeparatedList(AttributeArgument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal("api/[controller]")))))));
    //     return attributeListSyntax;
    // }

    private StringBuilder GetActionMethodString { get; set; }

    protected FieldDeclarationSyntax GetMapperFieldDeclaration() =>
        GetFieldDeclaration("_mapper", "IMapper");

    protected FieldDeclarationSyntax GetMediatorFieldDeclaration() =>
        GetFieldDeclaration("_mediator", "IMediator");
    
    protected override List<FieldDeclarationSyntax> FieldDeclarationSyntaxList =>
    [
        GetMapperFieldDeclaration(),
        GetMediatorFieldDeclaration()
    ];
    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return new[]
        {
            UsingDirective(ParseName(UsingStrings.Automapper)),
            UsingDirective(ParseName(UsingStrings.Mediatr)),
            UsingDirective(ParseName(UsingStrings.Dtos)),
            UsingDirective(ParseName(UsingStrings.Common)),
            UsingDirective(ParseName(UsingStrings.Mvc)),
            UsingDirective(ParseName($"{UsingStrings.Dtos}.{baseEntityName}")),
            UsingDirective(ParseName(string.Format(UsingStrings.CreateCommand, baseEntityName))),
            UsingDirective(ParseName(string.Format(UsingStrings.DeleteCommand, baseEntityName))),
            UsingDirective(ParseName(string.Format(UsingStrings.UpdateCommand, baseEntityName))),
            UsingDirective(ParseName(string.Format(UsingStrings.GetQuery, baseEntityName))),
            UsingDirective(ParseName(string.Format(UsingStrings.GetListQuery, baseEntityName))),
        };
    }
    
    protected override Maybe<ConstructorDeclarationSyntax> ConstructorDeclarationSyntax {
        get 
        {
            return ConstructorDeclaration(Identifier(TargetClassName))
                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                .AddParameterListParameters(Parameter(Identifier("mapper")).WithType(ParseTypeName("IMapper")))
                .AddParameterListParameters(Parameter(Identifier("mediator")).WithType(ParseTypeName("IMediator")))
                .AddBodyStatements(
                    ExpressionStatement(
                        AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName($"_mediator"),
                            IdentifierName($"mediator"))),
                    ExpressionStatement(
                        AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName("_mapper"),
                            IdentifierName("mapper")))
                );
        }
    }
    


    public ControllerGenerator(ClassDeclarationSyntax classDeclarationSyntax
    )
        : base(
            classDeclarationSyntax)
    {

        BaseDirectory=$"{Constants.RootDirectory}RiderProjects\\TrackMyMacros\\TrackMyMacros.Api\\Controllers\\";
        OutputDirectory = "";
        GetActionMethodString = new StringBuilder();
         GetActionMethodString.Append($@"
         public class ThisIsJustATemporaryContainerClass
         {{


             [HttpGet()]
             [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
             public async Task<IReadOnlyList<Get{BaseEntityClassName}Dto>> GetAll()
             {{
                 var {BaseEntityClassNameInCamelCase}Vms = await _mediator.Send(new Get{BaseEntityClassName}ListQuery());
                 return {BaseEntityClassNameInCamelCase}Vms;
             }}

             [HttpGet(""GetById/{{id}}"")]
             [ProducesResponseType(statusCode:StatusCodes.Status200OK)]  
             public async Task<ActionResult<Get{BaseEntityClassName}Dto>> Get{BaseEntityClassName}(Guid id)
             {{
                 var {BaseEntityClassName.ToLower()} = await _mediator.Send(new Get{BaseEntityClassName}Query {{ Id = id }});
                 return Ok({BaseEntityClassName.ToLower()}.Value);
             }}

             [HttpPut(Name = ""Update{BaseEntityClassName}"")]
             [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
             public async Task<IActionResult> Update{BaseEntityClassName}(Update{BaseEntityClassName}Dto create{BaseEntityClassName}Dto)
             {{
                 var result = await _mediator.Send(_mapper.Map<Update{BaseEntityClassName}Command>(create{BaseEntityClassName}Dto));
                 if (result is ValidationErrorResult)
                     return BadRequest(((ErrorResult)result).GetErrorString());
                 return Ok();
             }}

             [HttpPost(Name = ""Create{BaseEntityClassName}"")]
             [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
             public async Task<IActionResult> Create{BaseEntityClassName}(Create{BaseEntityClassName}Dto create{BaseEntityClassName}Dto)
             {{
                 var result = await _mediator.Send(_mapper.Map<Create{BaseEntityClassName}Command>(create{BaseEntityClassName}Dto));
                 if (result is ValidationErrorResult<Guid>)
                     return BadRequest(((ErrorResult<Guid>)result).GetErrorString());
                 return Ok();
             }}
             
             [HttpDelete( ""{{id}}"")]
             [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
             public async Task<IActionResult> Delete{BaseEntityClassName}(Guid id)
             {{
                 await _mediator.Send(new Delete{BaseEntityClassName}Command {{ Id = id}} );
                 return Ok();
             }}
         }}
         ");

    }
    
    
    
    protected override List<MethodDeclarationSyntax> MethodDeclarationSyntax {
        get
        {
            var list = new List<MethodDeclarationSyntax>();
            SyntaxTree tree = CSharpSyntaxTree.ParseText(GetActionMethodString.ToString());
            var handlerDeclaration= tree.GetCompilationUnitRoot().DescendantNodes().OfType<MethodDeclarationSyntax>();
            list.AddRange(handlerDeclaration);
            
            return list;
        }
    }

    protected override string BaseTypeString =>
        $"ControllerBase";


    protected override string TargetClassName => $"{BaseEntityClassName}Controller";

}