using Lookif.Layers.Core.Enums;
using Lookif.Layers.Core.MainCore.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lookif.Layers.Core.MainCore.Identities;

public  class User : IdentityUser<Guid>, IEntity<Guid>
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
    public DateTime LastLoginDate { get; set; } 

    public bool IsDeleted { get; set; }
   
    [StringLength(200)]
    public string Description { get; set; }
 
  

     
    public DateTime LastEditedDateTime { get; set; } = DateTime.Now;

}


 