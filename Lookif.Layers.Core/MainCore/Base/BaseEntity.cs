using System;

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
}
public abstract class BaseEntity<TKey> : IEntity<TKey>
{
    public TKey Id { get; set; }
    public DateTime LastEditedDateTime { get; set; } = DateTime.Now;
}

public abstract class BaseEntity : IEntity
{ 
    public Guid Id { get; set; }
    public DateTime LastEditedDateTime { get; set; } = DateTime.Now;
}