﻿using Lookif.Library.Common;

namespace Lookif.Layers.Core.Infrastructure.Base.DataInitializer
{
    public interface IDataInitializer : IScopedDependency
    {
        void InitializeData();
    }
}
