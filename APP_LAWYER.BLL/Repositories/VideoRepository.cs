using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.BLL.Repositories;

public class VideoRepository : GenericRepositoryAsync<Video>, IVideoRepository
{
    private readonly AppDbContext _db;
    public VideoRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }
    
    public async Task<List<Video>> GetVideosForSubcategory(Guid subcategoryId)
    {
        return await _db.SubcategoryVideos
            .Where(sv => sv.SubcategoryId == subcategoryId)
            .Select(sv => sv.Video)
            .ToListAsync();
    }
}