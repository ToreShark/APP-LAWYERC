using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class CommentRepository : GenericRepositoryAsync<Comment>, ICommentRepository
{
    private readonly AppDbContext _db;

    public CommentRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Comment>> GetBySubcategoryIdAsync(Guid subcategoryId)
    {
        return await _db.Comments
            .Include(c => c.User) // Include User data
            .Include(c => c.Replies) // Include Replies data
            .ThenInclude(r => r.User) // Include User data for each Reply
            .Where(c => c.SubcategoryId == subcategoryId)
            .ToListAsync();
    }

    public async Task<Comment> GetByCommentIdAsync(Guid commentId)
    {
        return await _db.Comments
            .Include(c => c.User) // Include User data
            .FirstOrDefaultAsync(c => c.Id == commentId);
    }
}