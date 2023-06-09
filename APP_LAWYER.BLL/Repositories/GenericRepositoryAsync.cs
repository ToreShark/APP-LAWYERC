using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
{
    private readonly AppDbContext _db;

    public GenericRepositoryAsync(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _db.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIDAsync(int id)
    {
        return await _db.Set<T>().FindAsync(id);
    }

    public async Task<T> GetByGuidAsync(Guid id)
    {
        return await _db.Set<T>().FindAsync(id);
    }

    public async Task<T> GetBySlugAsync(string slug)
    {
        return await _db.Set<T>().FindAsync(slug);
    }

    public async Task<T> InsertAsync(T entity)
    {
        await _db.Set<T>().AddAsync(entity);
        await _db.SaveChangesAsync();

        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _db.Entry(entity).State = EntityState.Modified;
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _db.Set<T>().Remove(entity);
        await _db.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<T>> GetPagedAsync(int page, int size)
    {
        return await _db.Set<T>().Skip((page - 1) * size).Take(size).ToListAsync();
    }

    public async Task<Subcategory> GetByGuidSubcategoryAsync(Guid id)
    {
        return await _db.Set<Subcategory>()
            .Include(s => s.Category)
            .Include(s => s.SubcategoryVideos)
            .ThenInclude(sv => sv.Video)
            .FirstOrDefaultAsync(s => s.Id == id);
    }
}