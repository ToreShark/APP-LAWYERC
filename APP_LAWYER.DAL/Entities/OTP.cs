using System.ComponentModel.DataAnnotations.Schema;

namespace APP_LAWYER.DAL.Entities;

public class Otp : BaseEntity
{
    public User User { get; set; }

    [Column("otp")] public int? Code { get; set; }

    [Column("expirationDate", TypeName = "timestamp")]
    public DateTime? ExpirationDate { get; set; }
}