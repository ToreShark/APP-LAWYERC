using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class SubcategoryRepository : GenericRepositoryAsync<Subcategory>, ISubcategoryRepository
{
    public SubcategoryRepository(AppDbContext db) : base(db)
    {
    }
}