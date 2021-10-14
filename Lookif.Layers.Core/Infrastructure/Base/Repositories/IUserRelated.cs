using Lookif.Layers.Core.MainCore.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lookif.Layers.Core.Infrastructure.Base.Repositories
{
    public interface IUserRelated
    {
        Task<User> GetByUserAndPass(string username, string password, CancellationToken cancellationToken);
        Task<User> GetById(Guid id, CancellationToken cancellationToken);

        Task AddAsync(User user, string password, CancellationToken cancellationToken);
        Task UpdateSecuirtyStampAsync(User user, CancellationToken cancellationToken);
        Task UpdateLastLoginDateAsync(User user, CancellationToken cancellationToken);
    }
}