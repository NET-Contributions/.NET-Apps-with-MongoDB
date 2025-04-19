using PostsAPI.CQRS.Commands;
using PostsAPI.CQRS.Queries;
using PostsAPI.Models;
using System.Web.Mvc;

namespace PostsAPI.Controllers;

public class BlogsController : Controller
{

    ILogger<Blog> _loggerBlog;

    //For Notice: Here we are using the CQRS pattern to separate the commands and queries
    IBlogsServiceCommands _commands;
    IBlogServiceQueries _queries;

    public BlogsController(
        ILogger<Blog> loggerBlog, IBlogsServiceCommands commands, IBlogServiceQueries queries)
    {
        _loggerBlog = loggerBlog;
        _commands = commands;
        _queries = queries;
    }

    [HttpGet]
    [Route("/blogs")]
    public ActionResult GetBlogList()
    {
        _loggerBlog.LogInformation("Retrieving blogs... ");

        var blogs = _queries.GetBlogList();

        return View("blogs", blogs);
    }

    [HttpPost]
    [Route("/createBlog")]
    public ActionResult CreateBlog(Blog blog)
    {
        _loggerBlog.LogInformation("Creating blog... ");
       
        var result = _commands.CreateBlog(blog);

        if (result == null)
        {
            _loggerBlog.LogError("Failed to create blog... ");
            return View("createBlog");
        }
        
        _loggerBlog.LogInformation("Blog created successfully... ");

        return RedirectToAction("GetBlogList");
    }
}
