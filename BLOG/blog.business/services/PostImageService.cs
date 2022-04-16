using blog.business.repositories;
using blog.data.models;
using blog.data.data;
using System.Collections.Generic;

namespace blog.business.services
{
    public class PostImageService : Repository<PostImage>, IPostImageRepository
    {
        public PostImageService(BlogContext context) : base(context)
        {
            
        }

        public void SetFalse(IEnumerable<PostImage> images)
        {
            foreach (PostImage image in images)
            {
                image.Active = false; 
            }
            Save();
        }
    }
}