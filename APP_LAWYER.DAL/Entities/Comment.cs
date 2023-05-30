using System.ComponentModel.DataAnnotations.Schema;

namespace APP_LAWYER.DAL.Entities;

public class Comment : BaseEntity
{
    public string Content { get; set; }

    [Column(TypeName = "timestamp")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedAt { get; set; }

    public User User { get; set; }

    public Subcategory Subcategory { get; set; }

    public List<Vote> Votes { get; set; }

    public List<Reply> Replies { get; set; }
}