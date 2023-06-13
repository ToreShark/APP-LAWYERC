using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class SubcategoryVideoRepository : GenericRepositoryAsync<SubcategoryVideo>, ISubcategoryVideoRepository
{
    private readonly AppDbContext _db;
    public SubcategoryVideoRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }
    
    public IQueryable<SubcategoryVideo> GetAll()
    {
        return _db.Set<SubcategoryVideo>().AsNoTracking();
    }
    public async Task<IEnumerable<SubcategoryVideo>> GetBySubcategoryIdAsync(Guid subcategoryId)
    {
        return await _db.Set<SubcategoryVideo>()
            .Where(sv => sv.SubcategoryId == subcategoryId)
            .AsNoTracking()
            .ToListAsync();
    }
    public async Task<Video> GetByIdAsync(Guid id)
    {
        return await _db.Set<Video>()
            .AsNoTracking()
            .FirstOrDefaultAsync(v => v.Id == id);
    }
}