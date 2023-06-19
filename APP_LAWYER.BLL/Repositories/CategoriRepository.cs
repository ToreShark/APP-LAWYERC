using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class CategoriRepository : GenericRepositoryAsync<Category>, ICategoryRepository
{
    private readonly AppDbContext _db;
    public CategoriRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }
    
    public async Task<Category> GetBySlugAsyncRepo(string slug)
    {
        return await _db.Categories.FirstOrDefaultAsync(c => c.Slug == slug);
    }
    public async Task<Category> GetByIdAsync(Guid id)
    {
        return await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);
    }

}