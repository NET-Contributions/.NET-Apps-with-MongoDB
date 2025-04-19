using MongoDB.Bson.Serialization.Attributes;

namespace PostsAPI.MongoDBSettings.Entities;

// classes are used to represent the data structure of the posts in the MongoDB database
public class PostEntity
{
    [BsonId]
    public int Id { get; set; }

    [BsonElement("title")]
    public string Title { get; set; }

    [BsonElement("content")]
    public string Content { get; set; }

    [BsonElement("author")]
    public string Author { get; set; }

    [BsonElement("created_at")]
    public DateTime CreatedAt { get; set; }

    [BsonElement("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [BsonElement("tags")]
    public string[] Tags { get; set; }

    [BsonElement("categories")]
    public string[] Categories { get; set; }

    [BsonElement("comments")]
    public string[] Comments { get; set; }

    [BsonElement("likes")]
    public string[] Likes { get; set; }

    [BsonElement("shares")]
    public string[] Shares { get; set; }

    [BsonElement("reactions")]
    public string[] Reactions { get; set; }

    [BsonElement("images")]
    public string[] Images { get; set; }

    [BsonElement("videos")]
    public string[] Videos { get; set; }

    [BsonElement("audio")]
    public string[] Audio { get; set; }

    [BsonElement("attachments")]
    public string[] Attachments { get; set; }

    [BsonElement("polls")]
    public string[] Polls { get; set; }

    [BsonElement("questions")]
    public string[] Questions { get; set; }

    [BsonElement("answers")]
    public string[] Answers { get; set; }

    [BsonElement("surveys")]
    public string[] Surveys { get; set; }

    [BsonElement("events")]
    public string[] Events { get; set; }

    [BsonElement("announcements")]
    public string[] Announcements { get; set; }

    [BsonElement("notifications")]
    public string[] Notifications { get; set; }

    [BsonElement("messages")]
    public string[] Messages { get; set; }

    [BsonElement("discussions")]
    public string[] Discussions { get; set; }

    [BsonElement("forums")]
    public string[] Forums { get; set; }

    [BsonElement("groups")]
    public string[] Groups { get; set; }

    [BsonElement("pages")]
    public string[] Pages { get; set; }

    [BsonElement("communities")]
    public string[] Communities { get; set; }

    [BsonElement("networks")]
    public string[] Networks { get; set; }

    [BsonElement("channels")]
    public string[] Channels { get; set; }

    [BsonElement("feeds")]
    public string[] Feeds { get; set; }

    [BsonElement("subscriptions")]
    public string[] Subscriptions { get; set; }

    [BsonElement("followers")]
    public string[] Followers { get; set; }

    [BsonElement("following")]
    public string[] Following { get; set; }

    [BsonElement("friends")]
    public string[] Friends { get; set; }

    [BsonElement("connections")]
    public string[] Connections { get; set; }

    [BsonElement("relationships")]
    public string[] Relationships { get; set; }

    [BsonElement("collaborations")]
    public string[] Collaborations { get; set; }

    [BsonElement("subjects")]
    public string[] Subjects { get; set; }

    [BsonElement("styles")]
    public string[] Styles { get; set; }

    [BsonElement("formats")]
    public string[] Formats { get; set; }

    [BsonElement("labels")]
    public string[] Labels { get; set; }

    [BsonElement("keywords")]
    public string[] Keywords { get; set; }
}
