using PostsAPI.Models;

namespace PostsAPI.CQRS.Commands;

// This interface defines the commands for creating, updating and deleting Blogs.
public interface IBlogsServiceCommands
{

    // This method could be returning a blog domain class instead of a string.
    string CreateBlog(Blog blog);
}