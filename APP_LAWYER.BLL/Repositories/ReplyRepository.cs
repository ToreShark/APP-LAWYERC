using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class ReplyRepository : GenericRepositoryAsync<Reply>, IReplyRepository
{
    private readonly AppDbContext _db;
    public ReplyRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }
    
    // надо создать такой метод GetByCommentIdAsync
    // и в этом методе сделать Include User
    public async Task<IEnumerable<Reply>> GetByCommentIdAsync(Guid commentId)
    {
        return await _db.Replies
            .Include(c => c.User) // Include User data
            .Where(c => c.CommentId == commentId)
            .ToListAsync();
    }
}