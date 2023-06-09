using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class OtpRepository : GenericRepositoryAsync<Otp>, IOtpRepository
{
    public OtpRepository(AppDbContext db) : base(db)
    {
    }
}