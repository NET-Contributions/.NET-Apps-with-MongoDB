namespace PostsAPI.CQRS.Queries;


// TThis interface can be used to define query methods related to posts.
public interface IPostServiceQueries
{

    // This method could be using post domain class instead of a List<string> of posts.
    List<string> GetPosts();
}
