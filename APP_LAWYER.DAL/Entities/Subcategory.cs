using System.ComponentModel.DataAnnotations.Schema;

namespace APP_LAWYER.DAL.Entities;

public class Subcategory : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Content { get; set; }
    public virtual Category? Category { get; set; }
    public string Slug { get; set; }
    public List<Comment> Comments { get; set; }
    public Guid CategoryId { get; set; }
    public List<SubcategoryVideo> SubcategoryVideos { get; set; }
}