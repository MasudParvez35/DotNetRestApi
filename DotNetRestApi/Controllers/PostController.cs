using DotNetRestApi.Data;
using DotNetRestApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Post> GetAll()
        {
            var posts = _context.Posts.ToList();
            return posts;
        }

        [HttpPost]
        public Post Add(Post post)
        {
            post.Title = "Test2";
            post.CreatedDate = DateTime.Now;
            _context.Posts.Add(post);
            bool isSaved = _context.SaveChanges() > 0;
            if (isSaved)
                return post;
            return null;
        }
    }
}
