using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class SubcategoryVideoRepository : GenericRepositoryAsync<SubcategoryVideo>, ISubcategoryVideoRepository
{
    public SubcategoryVideoRepository(AppDbContext db) : base(db)
    {
    }
}