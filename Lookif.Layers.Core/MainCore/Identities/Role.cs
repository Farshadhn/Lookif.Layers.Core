using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Lookif.Layers.Core.MainCore.Base;

namespace Lookif.Layers.Core.MainCore.Identities;

public class Role : IdentityRole<Guid>, IEntity 
{ 
    public string Description { get; set; }
    public DateTime LastEditedDateTime { get; set; } = DateTime.Now;
}

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
    }
}
