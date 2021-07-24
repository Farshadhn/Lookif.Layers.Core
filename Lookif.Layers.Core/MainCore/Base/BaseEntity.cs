using Lookif.Layers.Core.MainCore.Identities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lookif.Layers.Core.MainCore.Base
{
    public interface IEntity
    {
    }
    public interface IEntity<TKey> : IEntity
    {
        public TKey Id { get; set; }
        public DateTime InsertedDateTime { get; set; } // The time that is created 
        public DateTime LastEditedDateTime { get; set; } //The time that last change is happened
        public Guid? CreatorId { get; set; }
        public User Creator { get; set; }


        public Guid? LastEditedUserId { get; set; }
        public User LastEditedUser { get; set; }


        public bool IsDeleted { get; set; }//All users are stored via integer keys
    }

    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        protected BaseEntity()
        {
            var now = DateTime.Now;
            InsertedDateTime = now;
            LastEditedDateTime = now;
        }

        public TKey Id { get; set; }
        public DateTime InsertedDateTime { get; set; }
        public DateTime LastEditedDateTime { get; set; }


        public Guid? CreatorId { get; set; }
        [ForeignKey(nameof(CreatorId))]
        public virtual User Creator { get; set; }


        public Guid? LastEditedUserId { get; set; }
        [ForeignKey(nameof(LastEditedUserId))]
        public virtual User LastEditedUser { get; set; }


        public bool IsDeleted { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<Guid>
    {
    }
}
