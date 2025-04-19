namespace PostsAPI.MongoDBSettings.Repositories;

public class MongoDBSettings
{
    //You can add more properties as per your requirements
    public string ConnectionString { get; set; }
    public string DatabaseServer { get; set; }
    public string DatabasePort { get; set; }
    public string DatabaseUser { get; set; }
    public string DatabasePassword { get; set; }
    public string DatabaseAuthSource { get; set; }
    public string DatabaseAuthMechanism { get; set; }
    public string DatabaseReplicaSet { get; set; }
    public string DatabaseName { get; set; }
}


// For the sake of the example, we are just using a static class to hold the settings.
public static class BlogPostsAppSettings
{
    public static string DatabaseName => "BlogsPostsDB";
    public static string PostsCollectionName => "Posts";
    public static string BlogsCollectionName => "Blogs";
}
