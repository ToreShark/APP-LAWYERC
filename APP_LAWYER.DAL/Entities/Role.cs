using APP_LAWYER.DAL.Enums;

namespace APP_LAWYER.DAL.Entities;

public class Role : BaseEntity
{
    public RoleName RoleName { get; set; }
    public List<User> Users { get; set; }
}