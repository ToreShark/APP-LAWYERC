using APP_LAWYER.DAL.Entities;

namespace APP_LAWYER.WEB.Models;

public class NavbarCategoriesViewModel
{
    public IEnumerable<Category> Categories { get; set; }
}