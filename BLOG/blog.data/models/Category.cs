using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace blog.data.models
{
    public class Category : CoreEntity
    {
        [
            Required,
            MaxLength(50)
        ]
        public string Name { get; set; } 
        public virtual ICollection<PostCategory> PostCategories { get; set; }
    }
}