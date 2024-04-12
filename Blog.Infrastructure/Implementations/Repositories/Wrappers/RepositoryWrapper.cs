using Blog.Application.Interfaces.Repositories.Blog;
using Blog.Application.Interfaces.Repositories.Wrappers;
using Blog.Infrastructure.Implementations.Repositories.Blog;

namespace Blog.Infrastructure.Implementations.Repositories.Wrappers
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IBlogRepository _blogRepository;

        public RepositoryWrapper(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IBlogRepository Blog
        {
            get
            {
                _blogRepository ??= new BlogRepository();
                return _blogRepository;
            }
        }
    }
}
