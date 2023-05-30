using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class UserRepository: GenericRepositoryAsync<User>, IUserRepository
{
    public UserRepository(AppDbContext db) : base(db)
    {
    }
}