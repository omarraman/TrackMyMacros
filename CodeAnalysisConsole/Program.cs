// See https://aka.ms/new-console-template for more information

using CodeAnalysisConsole;
using CodeGen;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

string entityName = String.Empty;
while (true)
{
    Console.WriteLine("Entity Name?");
    entityName = Console.ReadLine() ?? String.Empty;
    if (!String.IsNullOrEmpty(entityName))
    {
        break;
    }
}


string? line;
while (true)
{
    Console.WriteLine("Enter the things you want to generate");
    Console.WriteLine(UserInput.CommandList());
    line = Console.ReadLine();
    if (!String.IsNullOrEmpty(line))
    {
        break;
    }
}

var userInputs = new UserInput(line);

if (userInputs == null)
{
    Console.WriteLine("Invalid input");
    return;
}



// var path = Path.GetDirectoryName(typeof (Program).Assembly.Location);
var sln = Path.Combine(Constants.RootDirectory,"RiderProjects\\TrackMyMacros\\TrackMyMacros.sln");
//var sln = Path.Combine($"{Constants.RootDirectory}RiderProjects\\TrackMyMacros\\TrackMyMacros.sln");

var workspace = MSBuildWorkspace.Create();
var solution = await workspace.OpenSolutionAsync(sln);


Project project = solution.Projects.First(x => x.Name == "TrackMyMacros.Domain");
Project sharedKernalProject = solution.Projects.First(x => x.Name == "TrackMyMacros.SharedKernel");
var compilation = await project.GetCompilationAsync();
var compilationSharedKernal = await sharedKernalProject.GetCompilationAsync();

var classVisitor = new ClassVirtualizationVisitor();
var sharedKernalClassVisitor = new ClassVirtualizationVisitor();


if (compilation?.SyntaxTrees != null)
    foreach (var syntaxTree in compilation?.SyntaxTrees!)
    {
        classVisitor.Visit(syntaxTree.GetRoot());
    }

if (compilationSharedKernal?.SyntaxTrees != null)
    foreach (var syntaxTree in compilationSharedKernal?.SyntaxTrees!)
    {
        sharedKernalClassVisitor.Visit(syntaxTree.GetRoot());
    }

var classes =
    classVisitor.Classes
        .Where(a => a.Identifier.Text == entityName)
        .Where(m => m.AttributeLists.Any(m => m.Attributes.Any(a => a.Name.ToString() == "CodeGen")));


var valueObjects = classVisitor.ValueObjects;
//add valueObjects from sharedKernalClassVisitor to valueObjects
valueObjects.AddRange(sharedKernalClassVisitor.ValueObjects);

if (!classes.Any())
{
    Console.WriteLine("No classes found with that name and/or CodeGen attribute");
    return;
}


foreach (var classDeclarationSyntax in classes)
{
    await GenerateRepositories(classDeclarationSyntax);
    
    await GenerateDataServiceClasses(classDeclarationSyntax);
    
    await GenerateControllerClasses(classDeclarationSyntax);

    await GenerateMappingClasses(classDeclarationSyntax);
    await GenerateViewModelMappingClasses(classDeclarationSyntax);
    
    await GenerateDtoClasses(classDeclarationSyntax);
    
    await GenerateCommandOrQueryClasses(classDeclarationSyntax);
    
    await GenerateCommandOrQueryHandlerClasses(classDeclarationSyntax);
    
    await GenerateValidatiorClasses(classDeclarationSyntax);
    
    await GenerateUiDialogClasses(classDeclarationSyntax);
    await GenerateUiAddPageClasses(classDeclarationSyntax);
    
    await GenerateUiListPageClasses(classDeclarationSyntax);
    
    await GenerateViewModels(classDeclarationSyntax);
}

async Task GenerateValidatiorClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (!userInputs.ShouldGenerateValidators)
        return;

    if (userInputs.ShouldGenerateCreate)
    {
        await ValidatorGenerator.CreateValidatorGenerator(classDeclarationSyntax).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateUpdate)
    {
        var v = ValidatorGenerator.UpdateValidatorGenerator(classDeclarationSyntax);
        try
        {
            await v.GenerateAndWriteClass2();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}

async Task GenerateCommandOrQueryClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (userInputs.ShouldGenerateCommandOrQueries == false)
        return;


    if (userInputs.ShouldGenerateGet)
    {
        await CommandOrQueryGenerator.GetCommandOrQueryGenerator(classDeclarationSyntax,valueObjects)
            .GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateGetList)
    {
        await CommandOrQueryGenerator.GetListCommandOrQueryGenerator(classDeclarationSyntax,valueObjects)
            .GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateCreate)
    {
        await CommandOrQueryGenerator.CreateCommandOrQueryGenerator(classDeclarationSyntax,valueObjects)
            .GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateDelete)
    {
        await CommandOrQueryGenerator.DeleteCommandOrQueryGenerator(classDeclarationSyntax,valueObjects)
            .GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateUpdate)
    {
        await CommandOrQueryGenerator.UpdateCommandOrQueryGenerator(classDeclarationSyntax,valueObjects)
            .GenerateAndWriteClass2();
    }
}

async Task GenerateCommandOrQueryHandlerClasses(ClassDeclarationSyntax classDeclarationSyntaxForBaseEntity)
{
    if (!userInputs.ShouldGenerateCommandOrQueryHandlers)
        return;

    if (userInputs.ShouldGenerateGet)
    {
        var getHandlerGenerator = new GetHandlerGenerator(classDeclarationSyntaxForBaseEntity);
        await getHandlerGenerator.GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateGetList)
    {
        var getListHandlerGenerator = new GetListHandlerGenerator(classDeclarationSyntaxForBaseEntity);
        await getListHandlerGenerator.GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateCreate)
    {
        var createHandlerGenerator = new CreateHandlerGenerator(classDeclarationSyntaxForBaseEntity);
        await createHandlerGenerator.GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateDelete)
    {
        var deleteHandlerGenerator = new DeleteHandlerGenerator(classDeclarationSyntaxForBaseEntity);
        await deleteHandlerGenerator.GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateUpdate)
    {
        var updateHandlerGenerator = new UpdateHandlerGenerator(classDeclarationSyntaxForBaseEntity);
        await updateHandlerGenerator.GenerateAndWriteClass2();
    }
}


async Task GenerateDtoClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (userInputs.ShouldGenerateDtos == false)
        return;

    if (userInputs.ShouldGenerateGet)
    {
        await DtoClassGenerator.GetDtoClassGenerator(classDeclarationSyntax,valueObjects).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateCreate)
    {
        await DtoClassGenerator.CreateDtoClassGenerator(classDeclarationSyntax,valueObjects).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateDelete)
    {
        await DtoClassGenerator.DeleteDtoClassGenerator(classDeclarationSyntax,valueObjects).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateUpdate)
    {
        await DtoClassGenerator.UpdateDtoClassGenerator(classDeclarationSyntax,valueObjects).GenerateAndWriteClass2();
    }
}

async Task GenerateMappingClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    // MappingProfileGenerator mappingGenerator =
    //     new MappingProfileGenerator(classDeclarationSyntax, MappingProfileGenerator.MappingProfileType.Update,valueObjects);
    // await mappingGenerator.GenerateAndWriteClass();
    // // if (userInputs.ShouldGenerateDtos==false)
    // //     return;
    // //

    if (!userInputs.ShouldGenerateMappings)
    {
        return;
    }
    
    if (userInputs.ShouldGenerateGet)
    {
        await MappingProfileGenerator.GetMappingProfileGenerator(classDeclarationSyntax,valueObjects, Maybe<string>.None,false).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateCreate)
    {
        await MappingProfileGenerator.CreateMappingProfileGenerator(classDeclarationSyntax,valueObjects, Maybe<string>.None,false).GenerateAndWriteClass2();
    }
    
    if (userInputs.ShouldGenerateUpdate)
    {
        await MappingProfileGenerator.UpdateMappingProfileGenerator(classDeclarationSyntax,valueObjects,Maybe<string>.None,false).GenerateAndWriteClass2();
    }

}

async Task GenerateViewModelMappingClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    // MappingProfileGenerator mappingGenerator =
    //     new MappingProfileGenerator(classDeclarationSyntax, MappingProfileGenerator.MappingProfileType.Update,valueObjects);
    // await mappingGenerator.GenerateAndWriteClass();
    // // if (userInputs.ShouldGenerateDtos==false)
    // //     return;
    // //

    if (!userInputs.ShouldGenerateViewModelMappings)
    {
        return;
    }
    
    if (userInputs.ShouldGenerateGet)
    {
        await ViewModelMappingProfileGenerator.GetViewModelMappingProfileGenerator(classDeclarationSyntax).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateCreate)
    {
        await ViewModelMappingProfileGenerator.CreateViewModelMappingProfileGenerator(classDeclarationSyntax).GenerateAndWriteClass2();
    }
    
    if (userInputs.ShouldGenerateUpdate)
    {
        await ViewModelMappingProfileGenerator.UpdateViewModelMappingProfileGenerator(classDeclarationSyntax).GenerateAndWriteClass2();
    }

}

async Task GenerateControllerClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (!userInputs.ShouldGenerateControllers)
    {
        return;
    }
    
    var controllerGenerator = new ControllerGenerator(classDeclarationSyntax);
    await controllerGenerator.GenerateAndWriteClass2();
}

async Task GenerateDataServiceClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (!userInputs.ShouldGenerateDataServices)
    {
        return;
    }
    
    var dataServiceGenerator = new DataServiceGenerator(classDeclarationSyntax);
    await dataServiceGenerator.GenerateAndWriteClass2();
}

async Task GenerateRepositories(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (!userInputs.ShouldGenerateRepositories)
    {
        return;
    }
    
    var generator = new RepositoryGenerator(classDeclarationSyntax);
    await generator.GenerateAndWriteClass2();
}

async Task GenerateUiDialogClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (!userInputs.ShouldGenerateDialog)
    {
        return;
    }
    
    var dataServiceGenerator = new AddOrUpdateDialogGenerator(classDeclarationSyntax);
    await dataServiceGenerator.GenerateAndWriteClass2();
}

async Task GenerateUiAddPageClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (!userInputs.ShouldGenerateUiAddPage)
    {
        return;
    }
    
    var dataServiceGenerator = new AddEntityPageCodeBehindGenerator(classDeclarationSyntax);
    await dataServiceGenerator.GenerateAndWriteClass2();
}

async Task GenerateUiListPageClasses(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (!userInputs.ShouldGenerateUiListPage)
    {
        return;
    }
    
    var generator = new ListUiPageGenerator(classDeclarationSyntax);
    await generator.GenerateAndWriteClass2();
}

async Task GenerateViewModels(ClassDeclarationSyntax classDeclarationSyntax)
{
    if (userInputs.ShouldGenerateViewModel == false)
        return;

    if (userInputs.ShouldGenerateGet)
    {
        await ViewModelGenerator.GetViewModelGenerator(classDeclarationSyntax,valueObjects).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateCreate)
    {
        await ViewModelGenerator.CreateViewModelGenerator(classDeclarationSyntax,valueObjects).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateDelete)
    {
        await ViewModelGenerator.DeleteViewModelGenerator(classDeclarationSyntax,valueObjects).GenerateAndWriteClass2();
    }

    if (userInputs.ShouldGenerateUpdate)
    {
        await ViewModelGenerator.UpdateViewModelGenerator(classDeclarationSyntax,valueObjects).GenerateAndWriteClass2();
    }
}


class ClassVirtualizationVisitor : CSharpSyntaxRewriter
{
    public ClassVirtualizationVisitor()
    {
        Classes = new List<ClassDeclarationSyntax>();
        ValueObjects = new List<ClassDeclarationSyntax>();
        Entities = new List<ClassDeclarationSyntax>();
    }

    public List<ClassDeclarationSyntax> Classes { get; set; }
    public List<ClassDeclarationSyntax> ValueObjects { get; set; }
    public List<ClassDeclarationSyntax> Entities { get; set; }

    public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        var visitedNode = base.VisitClassDeclaration(node);
        if (visitedNode is ClassDeclarationSyntax classDeclarationSyntax)
        {
            Classes.Add(classDeclarationSyntax);
            //if the classDeclarationSyntax parent is ValueObject
            // if (classDeclarationSyntax.Parent is ClassDeclarationSyntax parentClassDeclarationSyntax)
            // {
            //
            //     //add it to list of value objects
            //     ValueObjects.Add(parentClassDeclarationSyntax);
            // }

            //if classDeclarationSyntax has the ValueObject attribute
                if (classDeclarationSyntax.BaseList?.Types.Any(t => t.Type.ToString().Contains("ValueObject")) == true)
                {
                    //add it to list of value objects
                    ValueObjects.Add(classDeclarationSyntax);
                }
                if (classDeclarationSyntax.BaseList?.Types.Any(t => t.Type.ToString().Contains("Entity")) == true)
                {
                    Entities.Add(classDeclarationSyntax);
                }

            
        }

        return node;
    }
}



public class DtoIdentifier
{
    public static string Create(string className) => "Create" + className + "Dto";
    public static string Get(string className) => "Get" + className + "Dto";
    public static string Delete(string className) => "Delete" + className + "Dto";
    public static string Update(string className) => "Update" + className + "Dto";
}

public class CommandOrQueryIdentifier
{
    private static readonly string _commandExtension = "Command";
    private static readonly string _queryExtension = "Query";
    public static string Create(string className) => "Create" + className + _commandExtension;
    public static string Get(string className) => "Get" + className + _queryExtension;
    public static string GetList(string className) => "Get" + className + "List" + _queryExtension;
    public static string Delete(string className) => "Delete" + className + _commandExtension;
    public static string Update(string className) => "Update" + className + _commandExtension;
}
