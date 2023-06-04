using APP_LAWYER.DAL.Data;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Interfaces;

namespace APP_LAWYER.BLL.Repositories;

public class DocumentTemplateRepository : GenericRepositoryAsync<DocumentTemplate>, IDocumentTemplateRepository
{
    public DocumentTemplateRepository(AppDbContext db) : base(db)
    {
    }
}