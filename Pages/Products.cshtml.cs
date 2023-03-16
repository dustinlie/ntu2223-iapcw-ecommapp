using iapCoursework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iapCoursework2.Pages
{
    public class ProductsModel : PageModel
    {
        public readonly AppDataContext _db;
        public List<Product> Products { get; set; }

        public ProductsModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Products = _db.Products.ToList();
        }
        public IActionResult OnGetDelete(string Id)
        {
            _db.Remove(_db.Products.Find(Id));
            _db.SaveChanges();
            return RedirectToPage("./Products");
        }
    }
}
