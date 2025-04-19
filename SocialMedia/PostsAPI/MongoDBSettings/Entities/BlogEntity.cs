using PostsAPI.Models;

namespace PostsAPI.MongoDBSettings.Entities;

public class BlogEntity
{
    public string Name { get; set; }
    public Post[] Posts { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string[] Tags { get; set; }
}
