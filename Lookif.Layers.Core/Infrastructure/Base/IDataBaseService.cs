using Lookif.Layers.Core.Infrastructure.Base.DataInitializer;
using System.Collections.Generic;

namespace Lookif.Layers.Core.Infrastructure.Base
{
    public interface IDataBaseService
    {
        void RefreshDatabase(List<IDataInitializer> dataInitializers, bool Do_not_use_Migrations = false);
    }
}