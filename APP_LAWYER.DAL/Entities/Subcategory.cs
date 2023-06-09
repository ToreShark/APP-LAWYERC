namespace APP_LAWYER.DAL.Entities;

public class Subcategory : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string FullDescription { get; set; }
    public string? Image { get; set; }
    public string? ImagePath { get; set; }
    public string Content { get; set; }
    public virtual Category? Category { get; set; }
    public string Slug { get; set; }
    public List<Comment>? Comments { get; set; }
    public Guid CategoryId { get; set; }
    public List<SubcategoryVideo>? SubcategoryVideos { get; set; }
    public string MetaTitle { get; set; }
    public string MetaKeywords { get; set; }

    public string MetaDescription { get; set; }
    // public VideoInfo VideoInfo { get; set; }
}