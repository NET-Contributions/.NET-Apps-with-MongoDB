using PostsAPI.Models;

namespace PostsAPI.Services;

public interface IPostsService
{
    string CreatePost(Post post);

    List<string> GetPosts();
}