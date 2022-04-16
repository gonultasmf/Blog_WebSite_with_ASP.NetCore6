using blog.business.repositories;
using blog.data.models;
using blog.data.data;

namespace blog.business.services
{
    public class CategoryService : Repository<Category>, ICategoryRepository
    {
        public CategoryService(BlogContext context) : base(context)
        {
            
        }
    }
}