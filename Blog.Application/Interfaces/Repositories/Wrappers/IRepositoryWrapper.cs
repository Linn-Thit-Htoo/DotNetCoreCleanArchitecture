using Blog.Application.Interfaces.Repositories.Blog;

namespace Blog.Application.Interfaces.Repositories.Wrappers
{
    public interface IRepositoryWrapper
    {
        public IBlogRepository Blog { get; }
    }
}