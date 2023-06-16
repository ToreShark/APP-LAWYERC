namespace APP_LAWYER.DAL.Entities;

public class VideoInfo : BaseEntity
{
    public string Duration { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid VideoId { get; set; }
}