
using Lookif.Layers.Core.MainCore.Base;
using Lookif.Library.Common.Enums;
using Lookif.Library.Common.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lookif.Layers.Core.MainCore.Identities
{
    public class User : IdentityUser<Guid>, IEntity<Guid>, IValidatableObject
    {
        public User()
        {
            IsActive = true;

        }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public string ImagePath { get; set; }



        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; } 
        public DateTime LastEditedDateTime { get; set; } 
        public bool IsDeleted { get; set; }
        [NotMapped]
        public bool isFallowing { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [NotMapped]
        public bool IsInRole { get; set; }

        public bool Block { get; set; } 
        public Guid? LastEditedUserId { get; set; }
        public User LastEditedUser { get; set; }
        public string YaasPersonnelId{ get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!this.Email.IsValidEmail())
                yield return new ValidationResult("ایمیل وارد شده صحیح نمی باشد");


        }
    }

    //public class UserConfiguration : IEntityTypeConfiguration<User>
    //{
    //    public void Configure(EntityTypeBuilder<User> builder)
    //    {
    //        builder
    //           .HasOne(a => a.LastEditedUser)
    //           .WithOne(a => a.Creator);

    //    }
    //}

   
}

