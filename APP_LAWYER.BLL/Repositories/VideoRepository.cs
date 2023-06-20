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

    public async Task<Video> GetByIdAsync(Guid id)
    {
        return await _db.Set<Video>()
            .AsNoTracking()
            .FirstOrDefaultAsync(v => v.Id == id);
    }
    public async Task AddVideo(Video video)
    {
        await _db.Videos.AddAsync(video);
        await _db.SaveChangesAsync();
    }
}