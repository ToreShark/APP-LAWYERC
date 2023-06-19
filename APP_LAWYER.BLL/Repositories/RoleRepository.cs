using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Enums;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class RoleRepository : GenericRepositoryAsync<Role>, IRoleRepository
{
    private readonly AppDbContext _db;

    public RoleRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<int> GetBasicAsync()
    {
        return await _db.Roles.Where(x => x.RoleName == RoleName.Basic).Select(x => x.RoleId).FirstAsync();
    }

    public async Task<string> GetRoleNameById(Guid roleId)
    {
        var role = await GetByGuidAsync(roleId);
        if (role != null)
            return role.RoleName.ToString();
        throw new Exception("Role not found");
    }
}