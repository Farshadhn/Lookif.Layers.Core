namespace Lookif.Layers.Core.Infrastructure.Base.DataInitializer;

public interface IDataInitializer : IScopedDependency
{
    int order { get; set; }
    void InitializeData();
}
