namespace APP_LAWYER.DAL.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string FullDescription { get; set; }
    public string Slug { get; set; }
    public string ImageUrl { get; set; }
    public string ImageUrlSmall { get; set; }
    public string ImageUrlMedium { get; set; }
    public List<Subcategory> Subcategories { get; set; } = new();
}