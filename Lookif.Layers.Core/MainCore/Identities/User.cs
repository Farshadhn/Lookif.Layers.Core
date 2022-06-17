using Lookif.Layers.Core.Enums;
using Lookif.Layers.Core.MainCore.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lookif.Layers.Core.MainCore.Identities
{
    public  class User : IdentityUser<Guid>, IEntity
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

   
    }

 
   
}

