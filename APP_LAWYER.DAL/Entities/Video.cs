namespace APP_LAWYER.DAL.Entities;

public class Video : BaseEntity
{
    public string Url { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public List<SubcategoryVideo> SubcategoryVideos { get; set; }
}