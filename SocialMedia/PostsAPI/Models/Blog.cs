namespace PostsAPI.Models;

public class Blog
{
    public string Name { get; set; }
    public Post[] Posts { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string[] Tags { get; set; }
}
