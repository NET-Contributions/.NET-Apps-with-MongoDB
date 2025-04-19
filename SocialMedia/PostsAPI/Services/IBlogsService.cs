using PostsAPI.Models;

namespace PostsAPI.Services;

public interface IBlogsService
{
    string CreateBlog(Blog blog);
    List<string> GetBlogList();
}