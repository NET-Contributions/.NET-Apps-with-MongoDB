using MongoDB.Driver;
using PostsAPI.MongoDBSettings.Entities;

namespace PostsAPI.MongoDBSettings.Repositories;

// MongoDBContext class is used to manage the connection to the MongoDB database and collections
public class MongoDBContext
{
    MongoClient _client;

    IMongoCollection<PostEntity> _posts;
    IMongoCollection<BlogEntity> _blogs;

    public MongoDBContext(MongoClient client)
    {
        _client = client;
        var database = _client.GetDatabase("PostsDB");
        _posts = database.GetCollection<PostEntity>("Posts");
        _blogs = database.GetCollection<BlogEntity>("Users");
    }

    public IMongoCollection<PostEntity> Posts
    {
        get { return _posts; }
    }

    public IMongoCollection<BlogEntity> Blogs
    {
        get { return _blogs; }
    }
}
