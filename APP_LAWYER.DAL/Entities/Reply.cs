using System.ComponentModel.DataAnnotations.Schema;

namespace APP_LAWYER.DAL.Entities;

public class Reply : BaseEntity
{
    public string Text { get; set; }
    public Guid CommentId { get; set; }
    public Comment Comment { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}