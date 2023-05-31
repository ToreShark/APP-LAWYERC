using APP_LAWYER.DAL.Entities;

namespace APP_LAWYER.WEB.Models;

public class HomeViewModel
{
    public IEnumerable<Subcategory> Subcategories { get; set; }
    public IEnumerable<Category> Categories { get; set; }
}