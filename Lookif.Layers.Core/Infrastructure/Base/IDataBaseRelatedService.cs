using Lookif.Layers.Core.Infrastructure.Base.DataInitializer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lookif.Layers.Core.Infrastructure.Base;

public interface IDataBaseRelatedService
{
    Task RefreshDatabaseAsync(List<IDataInitializer> dataInitializers, bool Do_not_use_Migrations = false);
}