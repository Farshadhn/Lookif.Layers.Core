using Lookif.Layers.Core.MainCore.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks; 
namespace Lookif.Layers.Core.Infrastructure.Base
{
    public interface IBaseService<T, J>
        where T : class, IEntity<J>
    {

        Task<T> AddAsync(T t, CancellationToken cancellationToken, bool save = true);
        Task<IEnumerable<T>> AddRangeAsync(List<T> t, CancellationToken cancellationToken, bool save = true);
        T Add(T t, bool save = true);
        Task<T> UpdateAsync(T t, CancellationToken cancellationToken, bool save = true);
        Task<T> UpdateViaIdAsync(J t, CancellationToken cancellationToken, bool save = true);
        Task<T> DeleteAsync(T t, CancellationToken cancellationToken, bool save = true);
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(J id, CancellationToken cancellationToken);


    }
}
