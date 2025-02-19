using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.SharedKernel;

//1 add this to PersistenceServiceRegistration
//services.AddScoped<IExerciseRepository, ExerciseRepository>();
//2 add this to AppDbContext
//public DbSet<Exercise> Exercises { get; set; }
//3 put the repository interface in the application layer
//4 create a new migration
//5 update the database
// 6 add the following to the persistance layer,
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using TrackMyMacros.Domain.Aggregates.Exercise;
// namespace TrackMyMacros.Persistance.Repositories;
// public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
// {
// public void Configure(EntityTypeBuilder<Exercise> builder)
// {
// var ExerciseId = Guid.NewGuid();
// builder.OwnsMany(m => m.ExerciseFoodAmounts, recipeAmount =>
// {
//     recipeAmount.WithOwner().HasForeignKey("ExerciseId");
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
    public class ExerciseRepository : IExerciseRepository
    {
        private AppDbContext _dbContext;

        public ExerciseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<Exercise>> GetByIdAsync(Guid id)
        {
            var set = _dbContext.Set<Exercise>();
            var findAsync = await set.FindAsync(id);
            return findAsync ?? Maybe<Exercise>.None;
        }

        public async Task<IReadOnlyList<Exercise>> ListAllAsync()
        {
            var results = await _dbContext.Set<Exercise>().AsNoTracking().ToListAsync();
            if (!results.Any())
                return new List<Exercise>();
            return results;
        }

        public async virtual Task<IReadOnlyList<Exercise>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<Exercise>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<Exercise> AddAsync(Exercise entity)
        {
            await _dbContext.Set<Exercise>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Result> UpdateAsync(Exercise entity)
        {
            var exercise = await _dbContext.Set<Exercise>().FindAsync(entity.Id);
            _dbContext.Entry(exercise).CurrentValues.SetValues(entity);
            //exercise.ExerciseAmounts.Clear();
            //foreach (var exerciseAmount in entity.ExerciseAmounts)
            //{
            //    exercise.ExerciseAmounts.Add(exerciseAmount);    
            //}
            await _dbContext.SaveChangesAsync();
            return new SuccessResult();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbContext.Set<Exercise>().FindAsync(id);
            _dbContext.Set<Exercise>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}