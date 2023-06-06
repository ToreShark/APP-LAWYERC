using System.ComponentModel.DataAnnotations;

namespace APP_LAWYER.DAL.Entities;

public class DocumentEntity : BaseEntity
{
    public string Name { get; set; }
    [MaxLength(2000, ErrorMessage = "Description cannot be longer than 2000 characters.")]
    public string Description { get; set; } 
    public Guid UserId { get; set; }
    public virtual User? User { get; set; }
}