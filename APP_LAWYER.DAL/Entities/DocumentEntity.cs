namespace APP_LAWYER.DAL.Entities;

public class DocumentEntity : BaseEntity
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string UserId { get; set; }

    public User User { get; set; }
}