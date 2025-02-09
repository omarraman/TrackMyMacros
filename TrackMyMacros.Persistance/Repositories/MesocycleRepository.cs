using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

//1 add this to PersistenceServiceRegistration
//services.AddScoped<I{BaseEntityClassName}Repository, {BaseEntityClassName}Repository>();
//2 add this to AppDbContext
//public DbSet<{BaseEntityClassName}> {BaseEntityClassName}s { get; set; }
//3 put the repository interface in the application layer
//4 create a new migration
//5 update the database
// 6 add the following to the persistance layer,
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using TrackMyMacros.Domain.Aggregates.{BaseEntityClassName};
// namespace TrackMyMacros.Persistance.Repositories;
// public class {BaseEntityClassName}Configuration : IEntityTypeConfiguration<{BaseEntityClassName}>
// {
// public void Configure(EntityTypeBuilder<{BaseEntityClassName}> builder)
// {
// var {BaseEntityClassName}Id = Guid.NewGuid();
// builder.OwnsMany(m => m.{BaseEntityClassName}FoodAmounts, recipeAmount =>
// {
//     recipeAmount.WithOwner().HasForeignKey("{BaseEntityClassName}Id");
//     recipeAmount.Property(m => m.Quantity)
//         .IsRequired();
//     recipeAmount.Property(m => m.FoodId)
//         .IsRequired();
// }
// );
//
// }
// }
namespace TrackMyMacros.Persistance.Repositories
{
    public class MesocycleRepository : IMesocycleRepository
    {
        private AppDbContext _dbContext;

        public MesocycleRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<Mesocycle>> GetByIdAsync(Guid id)
        {
            var set = _dbContext.Set<Mesocycle>();
            var findAsync = await set.FindAsync(id);
            return findAsync ?? Maybe<Mesocycle>.None;
        }

        public async Task<IReadOnlyList<Mesocycle>> ListAllAsync()
        {
            var results = await _dbContext.Set<Mesocycle>().AsNoTracking().ToListAsync();
            if (!results.Any())
                return new List<Mesocycle>();
            return results;
        }

        public async virtual Task<IReadOnlyList<Mesocycle>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<Mesocycle>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<Mesocycle> AddAsync(Mesocycle entity)
        {
            await _dbContext.Set<Mesocycle>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Result> UpdateAsync(Mesocycle entity)
        {
            var mesoToRemove = _dbContext.Mesocycles.SingleOrDefault(m => m.Id == entity.Id);
            _dbContext.Mesocycles.Remove(mesoToRemove!);
            await _dbContext.SaveChangesAsync();
            _dbContext.Mesocycles.Add(entity!);
            await _dbContext.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbContext.Set<Mesocycle>().FindAsync(id);
            _dbContext.Set<Mesocycle>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

//     public interface IMesocycleRepository
//     {
//         Task<Maybe<Mesocycle>> GetByIdAsync(Guid id);
//         Task<IReadOnlyList<Mesocycle>> ListAllAsync();
//         Task<IReadOnlyList<Mesocycle>> GetPagedReponseAsync(int page, int size);
//         Task<Mesocycle> AddAsync(Mesocycle entity);
//         Task<Result> UpdateAsync(Mesocycle entity);
//         Task DeleteAsync(Guid id);
//     }
}