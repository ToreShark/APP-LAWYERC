using System.ComponentModel.DataAnnotations.Schema;

namespace APP_LAWYER.DAL.Entities;

public class Vote : BaseEntity
{
    [Column(TypeName = "bit")]
    public bool Value { get; set; } = true;

    public User User { get; set; }

    public Comment Comment { get; set; }

    [Column(TypeName = "datetime2")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "datetime2")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }
}