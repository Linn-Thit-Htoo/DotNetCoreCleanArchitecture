using Blog.Application.Interfaces.Repositories.Blog;
using Blog.Domain.Entities;
using Blog.Infrastructure.Data.MSSQL;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure.Implementations.Repositories.Blog
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _appDbContext = new();
        public async Task<List<BlogDataModel>> GetBlogs()
        {
            return await _appDbContext.Blogs
                .AsNoTracking()
                .OrderByDescending(x => x.BlogId)
                .ToListAsync();
        }
    }
}
