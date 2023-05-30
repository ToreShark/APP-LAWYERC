using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class ReplyRepository : GenericRepositoryAsync<Reply>, IReplyRepository
{
    public ReplyRepository(AppDbContext db) : base(db)
    {
    }
}