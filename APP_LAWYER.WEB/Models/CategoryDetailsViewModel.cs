using APP_LAWYER.DAL.Entities;

namespace APP_LAWYER.WEB.Models;

public class CategoryDetailsViewModel
{
    public Category Category { get; set; }
    public IEnumerable<Subcategory> Subcategories { get; set; }
}