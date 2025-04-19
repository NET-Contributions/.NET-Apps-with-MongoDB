namespace PostsAPI.CQRS.Queries;

// Optional: This interface can be used to define query methods related to blogs.
public interface IBlogServiceQueries
{
    //This method could be using blog domain class instead of a List<string> of posts.
    List<string> GetBlogList();
}
