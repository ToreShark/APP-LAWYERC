using System.ComponentModel.DataAnnotations;

namespace APP_LAWYER.DAL.Entities;

public class User : BaseEntity
{
    public User()
    {
        OtpCodes = new List<Otp>();
        Docs = new List<DocumentEntity>();
        Comments = new List<Comment>();
        Votes = new List<Vote>();
        Replies = new List<Reply>();
    }

    [Required]
    public string Phone { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    public string? Password { get; set; }
    public List<Otp> OtpCodes { get; set; }
    public List<DocumentEntity> Docs { get; set; }
    public int RoleId { get; set; }
    public virtual Role? Role { get; set; }

    public List<Comment> Comments { get; set; }
    public string? PaymentString { get; set; }

    // строка оплаты
    public List<Vote> Votes { get; set; }
    public List<Reply> Replies { get; set; }
}