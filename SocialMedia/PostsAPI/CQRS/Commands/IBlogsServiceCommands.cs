/****************  using PostsAPI.CircuitBreaking;  ****************/
using PostsAPI.Models;

namespace PostsAPI.CQRS.Commands;

// As an example of CQRS, combined with Circuit Breaker pattern, it could inherit from ICircuitBrokenService
// so that it would look like this:

/*
    public interface IBlogsServiceCommands : ICircuitBrokenService
    {

        // This method could be returning a blog domain class instead of a string.
        string CreateBlog(Blog blog);
    } 
*/


/**************** Default interface definition ****************/

/// <summary>
/// This interface defines the commands for creating, updating and deleting Blogs.
/// </summary>
public interface IBlogsServiceCommands
{

    // This method could be returning a blog domain class instead of a string.
    string CreateBlog(Blog blog);
}