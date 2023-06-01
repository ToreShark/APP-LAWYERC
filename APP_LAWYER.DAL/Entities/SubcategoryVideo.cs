namespace APP_LAWYER.DAL.Entities;

public class SubcategoryVideo
{
    public Guid SubcategoryId { get; set; }
    public Guid VideoId { get; set; }
    public virtual Subcategory? Subcategory { get; set; }
    public virtual Video? Video { get; set; }
}