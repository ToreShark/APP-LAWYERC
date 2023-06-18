using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class DocumentRepository : GenericRepositoryAsync<DocumentEntity>, IDocumentRepository
{
    public DocumentRepository(AppDbContext db) : base(db)
    {
    }
}