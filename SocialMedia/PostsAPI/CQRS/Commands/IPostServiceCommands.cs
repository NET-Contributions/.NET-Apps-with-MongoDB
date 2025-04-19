using PostsAPI.Models;

namespace PostsAPI.CQRS.Commands;


// This interface defines the commands such as creates deletes or updates for posts.
public interface IPostServiceCommands
{

    // This method is used to create a post.
    string CreatePost(Post post);
}