using System;

namespace blog.data.models
{
    public class PostImage : CoreEntity
    {
        public string ImageUrl { get; set; } 
        public bool Active { get; set; }
        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}