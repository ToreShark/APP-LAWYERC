namespace APP_LAWYER.DAL.Entities;

public class User : BaseEntity
{
    public string Phone { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public List<Otp> OtpCodes { get; set; }

    public List<DocumentEntity> Docs { get; set; }

    // public Role Role { get; set; } = Role.Regular;

    public List<Comment> Comments { get; set; }

    public List<Vote> Votes { get; set; }

    public List<Reply> Replies { get; set; }
}