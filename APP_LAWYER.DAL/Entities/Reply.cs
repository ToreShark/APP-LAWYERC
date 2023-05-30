using System.ComponentModel.DataAnnotations.Schema;

namespace APP_LAWYER.DAL.Entities;

public class Reply : BaseEntity
{
    public string Text { get; set; }

    public string CommentId { get; set; }
    public Comment Comment { get; set; }

    public string UserId { get; set; }
    public User User { get; set; }
}