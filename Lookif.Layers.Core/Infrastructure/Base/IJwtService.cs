using Lookif.Layers.Core.Else.JWT; 
using System.Threading.Tasks; 

namespace Lookif.Layers.Core.Infrastructure.Base;

public interface IJwtService<TUser>
{
    Task<AccessToken> GenerateAsync(TUser user);
}
