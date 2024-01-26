namespace MarcosTeste.Models;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public Category()
    {
        
    }

    public Category(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }
}