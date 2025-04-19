using PostsAPI.Models;

namespace PostsAPI.Services;

public class PostsService : IPostsService
{
    public string CreatePost(Post post)
    {
        // Logic to create a post
        // This is just a placeholder. In a real application, you would save the post to a database.
        return "Post created successfully!";
    }

    public List<string> GetPosts()
    {
        // logic to get posts.
        // In the real world this would be a database call.

        return new List<string>
        {
            "Post 1",
            "Post 2",
            "Post 3"
        };
    }
}
