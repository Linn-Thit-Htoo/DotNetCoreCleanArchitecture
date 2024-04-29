using Blog.Application.Interfaces.Repositories.Blog;

namespace Blog.Domain.Interfaces.Repositories.Wrappers
{
    public interface IRepositoryWrapper
    {
        public IBlogRepository Blog { get; }
    }
}