using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lookif.Layers.Core.Infrastructure.Base.Repositories;

public interface IUserRelated<TUser> 
where TUser : IdentityUser<Guid>
{
    Task<TUser> GetByUserAndPass(string username, string password, CancellationToken cancellationToken);
    Task<TUser> GetById(Guid id, CancellationToken cancellationToken);

    Task AddAsync(TUser user, string password, CancellationToken cancellationToken);
    Task UpdateSecurityStampAsync(TUser user, CancellationToken cancellationToken);
    Task UpdateLastLoginDateAsync(TUser user, CancellationToken cancellationToken);
}