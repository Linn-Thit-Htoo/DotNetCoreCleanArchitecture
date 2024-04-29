using Blog.Domain.Interfaces.Repositories.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public BlogController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogs()
        {
            try
            {
                return Ok(await _repositoryWrapper.Blog.GetBlogs());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
