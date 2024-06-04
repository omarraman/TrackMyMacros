using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class ViewModelGenerator : RecordTypeClassGenerator
{
    private ViewModelType _viewModelType;

    public static ViewModelGenerator CreateViewModelGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new ViewModelGenerator(classDeclarationSyntax, ViewModelType.Create,valueObjects);
    
    public static ViewModelGenerator GetViewModelGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new ViewModelGenerator(classDeclarationSyntax, ViewModelType.Get,valueObjects);
    
    public static ViewModelGenerator UpdateViewModelGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new ViewModelGenerator(classDeclarationSyntax, ViewModelType.Update,valueObjects);
    
    public static ViewModelGenerator DeleteViewModelGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new ViewModelGenerator(classDeclarationSyntax, ViewModelType.Delete,valueObjects);


    protected override string GetNewContainedTypeName(object? collectionTypeIdentifier, string replacementTypeArgument)
    {
        return $"{collectionTypeIdentifier}<{replacementTypeArgument}>";
    }

    protected override string GetNewTypeArgumentName(SeparatedSyntaxList<TypeSyntax> typeArgument)
    {
        return $"{_viewModelType}{typeArgument}ViewModel";
    }
    
    protected override string TargetClassName
    {
        get
        {
            switch (_viewModelType)
            {
                case ViewModelType.Create:
                    return ViewModelIdentifier.Create(BaseEntityClassName);
                case ViewModelType.Update:
                    return ViewModelIdentifier.Update(BaseEntityClassName);
                case ViewModelType.Get:
                    return ViewModelIdentifier.Get(BaseEntityClassName);
                case ViewModelType.Delete:
                    return ViewModelIdentifier.Delete(BaseEntityClassName);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private ViewModelGenerator(ClassDeclarationSyntax classDeclarationSyntax, ViewModelType viewModelType,List<ClassDeclarationSyntax> valueObjects) 
        : base(classDeclarationSyntax,valueObjects)
    {
        // _classDeclarationSyntax = classDeclarationSyntax;
        BaseDirectory= "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.App4\\ViewModels\\";
        OutputDirectory= BaseEntityClassName;

        _viewModelType = viewModelType;
        switch (viewModelType)
        {
            case ViewModelType.Create:
                MemberSelectionPredicate = _everythingApartFromIdPredicate;
                break;
            case ViewModelType.Update:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case ViewModelType.Get:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case ViewModelType.Delete:
                MemberSelectionPredicate = _onlyIdPredicate;
                break;
        }
    }

    private enum ViewModelType
    {
        Create,
        Update,
        Get,
        Delete
    }
    
    public class ViewModelIdentifier
    {
        public static string Create(string className) => "Create" + className + "ViewModel";
        public static string Get(string className) => "Get" + className + "ViewModel";
        public static string Delete(string className) => "Delete" + className + "ViewModel";
        public static string Update(string className) => "Update" + className + "ViewModel";
    }
}