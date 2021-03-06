using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Spcifications;

namespace Core.Interfaces
{
    public interface IGenericRepository <T> where T: BaseEntity
    {
        Task<T> GetbyIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecifications<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecifications<T> spec);
    }
}
