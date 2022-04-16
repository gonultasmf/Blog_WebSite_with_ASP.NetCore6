using Microsoft.Extensions.DependencyInjection;
using blog.business.repositories;
using blog.business.services;
using blog.data.data;
using Microsoft.EntityFrameworkCore;

namespace blog.root
{
    public class CompositionRoot
    {
        public CompositionRoot()
        {
        }

        public static void InjectDependecies(IServiceCollection services)
        {
            services.AddScoped<BlogContext>();
            services.AddScoped(typeof(IPostRepository), typeof(PostService));
            services.AddScoped(typeof(IPostImageRepository), typeof(PostImageService));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryService));

            services.AddDbContext<BlogContext>(options =>
                options.UseSqlServer("server=FMG; database=BlogDB; integrated security=true;", x => x.MigrationsAssembly("blog.ui")));
        }
    }
}