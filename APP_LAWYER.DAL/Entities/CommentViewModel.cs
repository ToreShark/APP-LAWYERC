using System.ComponentModel.DataAnnotations;

namespace APP_LAWYER.DAL.Entities;

public class CommentViewModel
{
    [Required]
    [StringLength(1000, ErrorMessage = "Comment cannot be longer than 1000 characters.")]
    public string Content { get; set; }

    public Guid SubcategoryId { get; set; }
    // Add other fields as necessary
}