using Microsoft.AspNetCore.Mvc;
using PostsAPI.CQRS.Commands;
using PostsAPI.CQRS.Queries;
using PostsAPI.Models;

namespace PostsAPI.Controllers;

[ApiController]
[Route("api/{controller}")]
public class PostsController : Controller
{
    ILogger<Post> _loggerPost;

    //For Notice: Here we are using the CQRS pattern to separate the commands and queries
    IPostServiceCommands _commands;
    IPostServiceQueries _queries;

    public PostsController(
        ILogger<Post> loggerPost, IPostServiceCommands post, IPostServiceQueries queries)
    {
        _loggerPost = loggerPost;
        _commands = post;
        _queries = queries;
    }

    [HttpGet]
    [Route("/posts")]
    public ActionResult Index()
    {
        _loggerPost.LogInformation("Retrieving posts... ");

        var posts = _queries.GetPosts();

        return View("posts", posts);
    }

    [HttpPost]
    [Route("/createPost")]
    public ActionResult CreatePost(Post post)
    {
        _loggerPost.LogInformation("Creating posts... ");

        var createPost = _commands.CreatePost(post);

        if (createPost == null)
            return BadRequest("Post creation failed.");

        _loggerPost.LogInformation("Post created successfully.");

        return View("post");
    }
}
