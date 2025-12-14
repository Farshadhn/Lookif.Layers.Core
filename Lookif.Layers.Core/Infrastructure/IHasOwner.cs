using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lookif.Layers.Core.Infrastructure;
public interface IHasOwner<TUser>
{
    public Guid OwnerId { get; set; }
    [ForeignKey(nameof(OwnerId))]
    public TUser Owner { get; set; }
}
