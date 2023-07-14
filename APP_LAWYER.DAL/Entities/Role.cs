using APP_LAWYER.DAL.Enums;

namespace APP_LAWYER.DAL.Entities;

public class Role 
{
    public int RoleId { get; set; }
    public RoleName RoleName { get; set; }
    public List<User> Users { get; set; }
}