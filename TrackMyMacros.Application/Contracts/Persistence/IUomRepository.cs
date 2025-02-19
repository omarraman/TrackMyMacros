
using TrackMyMacros.Domain;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IUomRepository
{
    Task<Maybe<Uom>> GetByIdAsync(Guid id);
    Task<IReadOnlyList<Uom>> ListAllAsync();
    Task<Uom> AddAsync(Uom entity);
    Task UpdateAsync(Uom entity);
    Task DeleteAsync(Uom entity);
    Task<IReadOnlyList<Uom>> GetPagedReponseAsync(int page, int size);
}
