using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class VoteRepository : GenericRepositoryAsync<Vote>, IVoteRepository
{
    public VoteRepository(AppDbContext db) : base(db)
    {
    }
}