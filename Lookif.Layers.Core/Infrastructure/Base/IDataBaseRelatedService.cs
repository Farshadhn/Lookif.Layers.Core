using Lookif.Layers.Core.Infrastructure.Base.DataInitializer;
using System.Collections.Generic;

namespace Lookif.Layers.Core.Infrastructure.Base
{
    public interface IDataBaseRelatedService
    {
        void RefreshDatabase(List<IDataInitializer> dataInitializers, bool Do_not_use_Migrations = false);
    }
}