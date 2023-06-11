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
}