using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class CategoriRepository : GenericRepositoryAsync<Category>, ICategoryRepository
{
    public CategoriRepository(AppDbContext db) : base(db)
    {
    }
}