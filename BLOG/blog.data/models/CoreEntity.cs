using System;
using System.ComponentModel.DataAnnotations;

namespace blog.data.models
{
    public interface ICoreEntity { }
    public abstract class CoreEntity : ICoreEntity
    {
        public CoreEntity()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}