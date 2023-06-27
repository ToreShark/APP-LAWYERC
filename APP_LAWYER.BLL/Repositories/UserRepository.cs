using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class UserRepository : GenericRepositoryAsync<User>, IUserRepository
{
    private readonly AppDbContext _db;

    public UserRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<User?> ValidateLoginPasswordAsync(string phoneNumber, string password)
    {
        var user = await _db.Users.Where(x => x.Phone == phoneNumber).FirstAsync();
        if (user == null) throw new InvalidOperationException("User with provided phone number not found");
        var newPassword = BCrypt.Net.BCrypt.Verify(password, user.Password);
        if (newPassword) return user;
        return null;
    }

    public async Task<User> GetByPhoneNumberAsync(string phoneNumber)
    {
        var user = await _db.Users.Where(x => x.Phone == phoneNumber).FirstOrDefaultAsync();
        if (user == null) return null;
        return user;
    }

    public string PasswordHash(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
    public async Task<List<User>> GetAllUsers()
    {
        return await _db.Users.ToListAsync();
    }
    
    public async Task<User> GetUserById(Guid id)
    {
        return await _db.Users.FindAsync(id);
    }
}