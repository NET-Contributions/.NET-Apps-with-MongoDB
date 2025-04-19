using BlogsPosts.Models;


using Microsoft.AspNetCore.Mvc;

namespace PostsAPI.Controllers;

[ApiController]
[Route("api/{controller}")]
public class PostsController : Controller
{
    ILogger<Posts> _posts
    public PostsController()
    {

    }

    [HttpGet]
    [Route("/posts")]
    public ActionResult Index()
    {
        return View("");
    }

    [HttpPost]
    public 
}
