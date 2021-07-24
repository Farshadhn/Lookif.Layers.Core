using Lookif.Layers.Core.Else.JWT;
using Lookif.Layers.Core.MainCore.Identities;
using System.Threading.Tasks; 

namespace Lookif.Layers.Core.Infrastructure.Base
{
    public interface IJwtService
    {
        Task<AccessToken> GenerateAsync(User user);
    }
    
}