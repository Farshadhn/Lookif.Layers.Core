using System.Threading.Tasks;

namespace Lookif.Layers.Core.Infrastructure.Base.DataInitializer;

public interface IDataInitializer : IScopedDependency
{
    int order { get; set; }
    Task InitializeDataAsync();
}
