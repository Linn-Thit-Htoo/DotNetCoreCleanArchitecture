using Blog.Domain.Entities;

namespace Blog.Application.Interfaces.Repositories.Blog
{
    public interface IBlogRepository
    {
        Task<List<BlogDataModel>> GetBlogs();
    }
}
