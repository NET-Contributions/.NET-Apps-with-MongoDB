using PostsAPI.Models;
using PostsAPI.Services;
using System.Web.Mvc;

namespace PostsAPI.Controllers;

public class BlogsController : Controller
{
    ILogger<Blog> _loggerBlog;
    IBlogsService _blogService;
    public BlogsController(
        ILogger<Blog> loggerBlog, IBlogsService blogService)
    {
        _loggerBlog = loggerBlog;
        _blogService = blogService;
    }

    [HttpGet]
    [Route("/blogs")]
    public ActionResult GetBlogList()
    {
        _loggerBlog.LogInformation("Retrieving blogs... ");

        var blogs = _blogService.GetBlogList();

        return View("blogs", blogs);
    }

    [HttpPost]
    [Route("/createBlog")]
    public ActionResult CreateBlog(Blog blog)
    {
        _loggerBlog.LogInformation("Creating blog... ");
       
        var result = _blogService.CreateBlog(blog);

        if (result == null)
        {
            _loggerBlog.LogError("Failed to create blog... ");
            return View("createBlog");
        }
        
        _loggerBlog.LogInformation("Blog created successfully... ");

        return RedirectToAction("GetBlogList");
    }
}
