using blog.data.models;
using blog.data.data;
using blog.business.repositories;

namespace blog.business.services
{
    public class PostService : Repository<Post>, IPostRepository
    {
        public PostService(BlogContext context) : base(context)
        {
            
        }
    }
}