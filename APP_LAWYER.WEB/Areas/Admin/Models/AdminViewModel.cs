using APP_LAWYER.DAL.Entities;

namespace APP_LAWYER.WEB.Areas.Admin.Models;

public class AdminViewModel
{
    public List<Category> Categories { get; set; }
    public List<Subcategory> Subcategories { get; set; }
    public List<DocumentTemplate> DocumentTemplates { get; set; }
}