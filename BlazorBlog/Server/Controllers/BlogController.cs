using BlazorBlog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBlog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
          new BlogPost { Url="new-tutorial", Title = "A New Tutorial about Blazor WEB APİ", Description = "This is a new tutorial, showing you how to build a blog with Blazor", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
          new BlogPost { Url="first-post", Title = "My First Blog Post WEB APİ", Description = "Hi! This is a my new  shiny blog. Enjoy!", Content = "This is a beatiful short blog post. Isn't it nice?"},
        };
        [HttpGet]
        public ActionResult<List<BlogPost>> GimmeAllTheBlogPosts()
        {
            return Ok(Posts);
        }
        [HttpGet("{url}")]
        public ActionResult<BlogPost> GimmeThatSingelBlogPost(string url)
        {
            var post = Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
            if(post == null )
            {
                return NotFound("This post does not exits.");
            }

            return Ok(post);
        }
                        
    }
}
