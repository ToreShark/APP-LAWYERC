using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class UserRepository: GenericRepositoryAsync<User>, IUserRepository
{
    private readonly AppDbContext _db;
    public UserRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }
    public async Task<User?> ValidateLoginPasswordAsync(string phoneNumber, string password)
    {
        User user = await _db.Users.Where(x=>x.Phone == phoneNumber).FirstAsync();
        if(user == null)
        {
            return null;
        }
        bool newPassword = BCrypt.Net.BCrypt.Verify(password, user.Password);
        if(newPassword)
        {
            return user;
        }
        return null;
    }
    public async Task<User> GetByPhoneNumberAsync(string phoneNumber)
    {
        User user = await _db.Users.Where(x=>x.Phone == phoneNumber).FirstOrDefaultAsync();
        if (user == null)
        {
            return null;
        }
        return user;
    }
    public string PasswordHash(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
}