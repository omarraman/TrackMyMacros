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

public class RepositoryGenerator : Generator
{

    private StringBuilder GetRepositoryMethodsString { get; set; }


    protected override UsingDirectiveSyntax[] GetUsingNamespaces(string baseEntityName)
    {
        return new[]
        {
            UsingDirective(ParseName(UsingStrings.Aggregates)),
            UsingDirective(ParseName($"{UsingStrings.Aggregates}.{baseEntityName}")),
            UsingDirective(ParseName(UsingStrings.Infrastructure)),
            UsingDirective(ParseName(UsingStrings.Persistance)),
            UsingDirective(ParseName(UsingStrings.EfCore)),
        };
    }

    protected override List<string> Comments =>
    [
        "//1 add this to PersistenceServiceRegistration",
        "//services.AddScoped<I{BaseEntityClassName}Repository, {BaseEntityClassName}Repository>();",
        "//2 add this to AppDbContext",
        "//public DbSet<{BaseEntityClassName}> {BaseEntityClassName}s { get; set; }",
        "//3 put the repository interface in the application layer",
        "//4 create a new migration",
        "//5 update the database",
        "// 6 add the following to the persistance layer,",
        "// using Microsoft.EntityFrameworkCore.Metadata.Builders;",
        "// using TrackMyMacros.Domain.Aggregates.{BaseEntityClassName};",
        "// namespace TrackMyMacros.Persistance.Repositories;",
        "// public class {BaseEntityClassName}Configuration : IEntityTypeConfiguration<{BaseEntityClassName}>",
        "// {",
        "// public void Configure(EntityTypeBuilder<{BaseEntityClassName}> builder)",
        "// {",
        "// var {BaseEntityClassName}Id = Guid.NewGuid();",
        "// builder.OwnsMany(m => m.{BaseEntityClassName}FoodAmounts, recipeAmount =>",
        "// {",
        "//     recipeAmount.WithOwner().HasForeignKey(\"{BaseEntityClassName}Id\");",
        "//     recipeAmount.Property(m => m.Quantity)",
        "//         .IsRequired();",
        "//     recipeAmount.Property(m => m.FoodId)",
        "//         .IsRequired();",
        "// }",
        "// );",
        "//",
        "// }",
        "// }",
    ];

    public RepositoryGenerator(ClassDeclarationSyntax classDeclarationSyntax
    )
        : base(
            classDeclarationSyntax)
    {

        BaseDirectory=$"{Constants.RootDirectory}RiderProjects\\TrackMyMacros\\TrackMyMacros.Persistance\\Repositories";
        OutputDirectory = "";
        GetRepositoryMethodsString = new StringBuilder();
          GetRepositoryMethodsString.Append($@"
              public class ThisIsJustATemporaryContainerClass
              {{


                      protected readonly AppDbContext _dbContext;

                      public {BaseEntityClassName}Repository(AppDbContext dbContext)
                      {{
                          _dbContext = dbContext;

                      //add this to PersistenceServiceRegistration
                      //services.AddScoped<I{BaseEntityClassName}Repository, {BaseEntityClassName}Repository>();
                      //add this to AppDbContext
                      //public DbSet<{BaseEntityClassName}> {BaseEntityClassName}s {{ get; set; }}

                      }}

                      public virtual async Task<Maybe<{BaseEntityClassName}>> GetByIdAsync(Guid id)
                      {{
                          var set = _dbContext.Set<{BaseEntityClassName}>();
                          var findAsync = await set.FindAsync(id);
                          return findAsync ?? Maybe<{BaseEntityClassName}>.None;
                      }}

                      public async Task<IReadOnlyList<{BaseEntityClassName}>> ListAllAsync()
                      {{
                          var results = await _dbContext.Set<{BaseEntityClassName}>().AsNoTracking().ToListAsync();
                          if (!results.Any())
                              return new List<{BaseEntityClassName}>();
                          
                          return results;
                      }}

                      public async virtual Task<IReadOnlyList<{BaseEntityClassName}>> GetPagedReponseAsync(int page, int size)
                      {{
                          return await _dbContext.Set<{BaseEntityClassName}>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
                      }}

                      public async Task<{BaseEntityClassName}> AddAsync({BaseEntityClassName} entity)
                      {{
                          await _dbContext.Set<{BaseEntityClassName}>().AddAsync(entity);
                          await _dbContext.SaveChangesAsync();

                          return entity;
                      }}

                      public async Task<Result> UpdateAsync({BaseEntityClassName} entity)
                      {{

                          var {BaseEntityClassNameInCamelCase}= await _dbContext.Set<{BaseEntityClassName}>().FindAsync(entity.Id);
                          _dbContext.Entry({BaseEntityClassNameInCamelCase}).CurrentValues.SetValues(entity);

                          //{BaseEntityClassNameInCamelCase}.{BaseEntityClassName}Amounts.Clear();
                          
                          //foreach (var {BaseEntityClassNameInCamelCase}Amount in entity.{BaseEntityClassName}Amounts)
                          //{{
                          //    {BaseEntityClassNameInCamelCase}.{BaseEntityClassName}Amounts.Add({BaseEntityClassNameInCamelCase}Amount);    
                          //}}
                          
                          await _dbContext.SaveChangesAsync();

                          return new SuccessResult();
                      }}

                      public async Task DeleteAsync(Guid id)
                      {{
                          var entity = await _dbContext.Set<{BaseEntityClassName}>().FindAsync(id);
                          _dbContext.Set<{BaseEntityClassName}>().Remove(entity);
                          await _dbContext.SaveChangesAsync();
                      }}
              }}


          ");

    }
    
    
    protected override List<MethodDeclarationSyntax> MethodDeclarationSyntax {
        get
        {
            var list = new List<MethodDeclarationSyntax>();
            SyntaxTree tree = CSharpSyntaxTree.ParseText(GetRepositoryMethodsString.ToString());
            var handlerDeclaration= tree.GetCompilationUnitRoot().DescendantNodes().OfType<MethodDeclarationSyntax>();
            list.AddRange(handlerDeclaration);
            
            return list;
        }
    }
    protected override Maybe<InterfaceDeclarationSyntax> InterfaceDeclarationSyntax {
        get
        {
            var x = new StringBuilder();
            x.Append($@"
            public interface I{BaseEntityClassName}Repository
            {{
                Task<Maybe<{BaseEntityClassName}>> GetByIdAsync(Guid id);
                Task<IReadOnlyList<{BaseEntityClassName}>> ListAllAsync();
                Task<IReadOnlyList<{BaseEntityClassName}>> GetPagedReponseAsync(int page, int size);
                Task<{BaseEntityClassName}> AddAsync({BaseEntityClassName} entity);
                Task<Result> UpdateAsync({BaseEntityClassName} entity);
                Task DeleteAsync(Guid id);
            }}
");
            SyntaxTree tree = CSharpSyntaxTree.ParseText(x.ToString());
            var interfaceDeclarationSyntax = tree.GetCompilationUnitRoot().DescendantNodes().OfType<InterfaceDeclarationSyntax>().First();
            return interfaceDeclarationSyntax;
        }
    }

    protected override string BaseTypeString =>
        $"I{BaseEntityClassName}Repository";

    protected FieldDeclarationSyntax GetDbContextFieldDeclaration() =>
        GetFieldDeclaration("_dbContext", "AppDbContext");
    
    protected override List<FieldDeclarationSyntax> FieldDeclarationSyntaxList =>
    [
        GetDbContextFieldDeclaration()
    ];
    protected override string TargetClassName => $"{BaseEntityClassName}Repository";
    
    protected override Maybe<ConstructorDeclarationSyntax> ConstructorDeclarationSyntax =>
        ConstructorDeclaration(Identifier(TargetClassName))
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            .AddParameterListParameters(Parameter(Identifier("dbContext")).WithType(ParseTypeName("AppDbContext")))
            .AddBodyStatements(
                ExpressionStatement(
                    AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                        IdentifierName($"_dbContext"),
                        IdentifierName($"dbContext")))
            );
}