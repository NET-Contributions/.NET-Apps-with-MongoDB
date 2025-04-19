using Microsoft.AspNetCore.Mvc;
using PostsAPI.Models;
using PostsAPI.Services;

namespace PostsAPI.Controllers;

[ApiController]
[Route("api/{controller}")]
public class PostsController : Controller
{
    ILogger<Post> _loggerPost;
    IPostsService _post;
    public PostsController(
        ILogger<Post> loggerPost, IPostsService post)
    {
        _loggerPost = loggerPost;
    }

    [HttpGet]
    [Route("/posts")]
    public ActionResult Index()
    {
        _loggerPost.LogInformation("Retrieving posts... ");

        var posts = _post.GetPosts();

        return View("posts", posts);
    }

    [HttpPost]
    [Route("/createPost")]
    public ActionResult CreatePost(Post post)
    {
        _loggerPost.LogInformation("Creating posts... ");

        var createPost = _post.CreatePost(post);

        if (createPost == null)
            return BadRequest("Post creation failed.");

        _loggerPost.LogInformation("Post created successfully.");

        return View("post");
    }
}
