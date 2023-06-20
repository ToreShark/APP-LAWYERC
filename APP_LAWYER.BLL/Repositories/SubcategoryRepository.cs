using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class SubcategoryRepository : GenericRepositoryAsync<Subcategory>, ISubcategoryRepository
{
    private readonly AppDbContext _db;

    public SubcategoryRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Subcategory>> GetByCategoryIdAsync(Guid categoryId)
    {
        return await _db.Subcategories
            .Where(s => s.CategoryId == categoryId)
            .ToListAsync();
    }
    public async Task<Subcategory> GetBySlugAsyncRepo(string slug)
    {
        return await _db.Subcategories
            .FirstOrDefaultAsync(s => s.Slug == slug);
    }
    public async Task<IEnumerable<Subcategory>> GetSubcategoriesForCategory(Guid categoryId)
    {
        return await _db.Subcategories
            .Where(s => s.CategoryId == categoryId)
            .ToListAsync();
    }

}