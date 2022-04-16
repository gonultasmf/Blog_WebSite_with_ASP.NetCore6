using blog.data.models;

namespace blog.business.repositories
{
    public interface IPostImageRepository : IRepository<PostImage>
    {
        void SetFalse(IEnumerable<PostImage> images);
    }
}