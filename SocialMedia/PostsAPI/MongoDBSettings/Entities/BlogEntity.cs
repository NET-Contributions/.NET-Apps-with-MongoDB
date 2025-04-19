using MongoDB.Bson.Serialization.Attributes;
using PostsAPI.Models;

namespace PostsAPI.MongoDBSettings.Entities;

// classes are used to represent the data structure of the blogs in the MongoDB database
public class BlogEntity
{
    [BsonId]
    public string Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("posts")]
    public Post[] Posts { get; set; }

    [BsonElement("description")]
    public string Description { get; set; }

    [BsonElement("author")]
    public string Author { get; set; }

    [BsonElement("createdAt")]
    public DateTime CreatedAt { get; set; }

    [BsonElement("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [BsonElement("tags")]
    public string[] Tags { get; set; }
}
