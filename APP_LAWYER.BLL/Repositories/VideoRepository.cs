using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class VideoRepository : GenericRepositoryAsync<Video>, IVideoRepository
{
    public VideoRepository(AppDbContext db) : base(db)
    {
    }
}