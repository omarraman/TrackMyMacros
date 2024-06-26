﻿using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGen;

public class DtoClassGenerator : RecordTypeClassGenerator
{
    private DtoType _dtoType;
    // private ClassDeclarationSyntax _classDeclarationSyntax;

    public static DtoClassGenerator CreateDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Create,valueObjects);
    
    public static DtoClassGenerator GetDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Get,valueObjects);
    
    public static DtoClassGenerator UpdateDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Update,valueObjects);
    
    public static DtoClassGenerator DeleteDtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax,List<ClassDeclarationSyntax> valueObjects) =>
        new DtoClassGenerator(classDeclarationSyntax, DtoType.Delete,valueObjects);


    protected override string GetNewContainedTypeName(object? collectionTypeIdentifier, string replacementTypeArgument)
    {
        return $"{collectionTypeIdentifier}<{replacementTypeArgument}>";
    }

    protected override string GetNewTypeArgumentName(SeparatedSyntaxList<TypeSyntax> typeArgument)
    {
        return $"{_dtoType}{typeArgument}Dto";
    }
    
    protected override string TargetClassName
    {
        get
        {
            switch (_dtoType)
            {
                case DtoType.Create:
                    return DtoIdentifier.Create(BaseEntityClassName);
                case DtoType.Update:
                    return DtoIdentifier.Update(BaseEntityClassName);
                case DtoType.Get:
                    return DtoIdentifier.Get(BaseEntityClassName);
                case DtoType.Delete:
                    return DtoIdentifier.Delete(BaseEntityClassName);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private DtoClassGenerator(ClassDeclarationSyntax classDeclarationSyntax, DtoType dtoType,List<ClassDeclarationSyntax> valueObjects) 
        : base(classDeclarationSyntax,valueObjects)
    {
        // _classDeclarationSyntax = classDeclarationSyntax;
        BaseDirectory= "C:\\Users\\OmarRaman\\RiderProjects\\TrackMyMacros\\TrackMyMacros.Dtos\\";
        OutputDirectory= BaseEntityClassName;

        _dtoType = dtoType;
        switch (dtoType)
        {
            case DtoType.Create:
                MemberSelectionPredicate = _everythingApartFromIdPredicate;
                break;
            case DtoType.Update:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case DtoType.Get:
                MemberSelectionPredicate = _allMembersPredicate;
                break;
            case DtoType.Delete:
                MemberSelectionPredicate = _onlyIdPredicate;
                break;
        }
    }

    private enum DtoType
    {
        Create,
        Update,
        Get,
        Delete
    }
}