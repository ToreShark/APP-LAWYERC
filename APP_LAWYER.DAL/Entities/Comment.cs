using System.ComponentModel.DataAnnotations.Schema;

namespace APP_LAWYER.DAL.Entities;

public class Comment : BaseEntity
{
    public string Content { get; set; }

    [Column(TypeName = "datetime2")]
    // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedAt { get; set; }

    public virtual User? User { get; set; }
    public virtual Subcategory? Subcategory { get; set; }
    public Guid UserId { get; set; }
    public Guid SubcategoryId { get; set; }
    public List<Vote> Votes { get; set; }
    public List<Reply> Replies { get; set; }
}