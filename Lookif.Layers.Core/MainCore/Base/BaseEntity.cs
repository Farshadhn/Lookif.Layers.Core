
using Lookif.Layers.Core.MainCore.Identities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lookif.Layers.Core.MainCore.Base;

/// <summary>
/// This is used to tag all entities
/// </summary>
public interface IEntity : IEntity<Guid>
{
}
public interface IEntity<TKey>
{
    public TKey Id { get; set; }
    public DateTime LastEditedDateTime { get; set; } //The time that last change is happened


    public Guid? LastEditedUserId { get; set; }
    public User LastEditedUser { get; set; }

     
}
public abstract class BaseEntity<TKey> : IEntity<TKey>
{
    protected BaseEntity()
    {
        var now = DateTime.Now; 
        LastEditedDateTime = now;
    }

    public TKey Id { get; set; } 
    public DateTime LastEditedDateTime { get; set; }

     


    public Guid? LastEditedUserId { get; set; }
    [ForeignKey(nameof(LastEditedUserId))]
    public virtual User LastEditedUser { get; set; }

     
}

public abstract class BaseEntity : BaseEntity<Guid>
{
}
