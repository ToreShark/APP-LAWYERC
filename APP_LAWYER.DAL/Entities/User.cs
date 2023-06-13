namespace APP_LAWYER.DAL.Entities;

public class User : BaseEntity
{
    public string Phone { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Otp> OtpCodes { get; set; }
    public List<DocumentEntity> Docs { get; set; }
    public int RoleId { get; set; }
    public virtual Role? Role { get; set; }
    public List<Comment> Comments { get; set; }
    // строка оплаты
    public List<Vote> Votes { get; set; }
    public List<Reply> Replies { get; set; }
}