using iapCoursework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace iapCoursework2.Pages
{
    public class CategoryProductModel : PageModel
    {
        public readonly AppDataContext _db;

        public List<Product> CProducts { get; set; }

        public CategoryProductModel(AppDataContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            CProducts = await _db.Products.Where(p => p.Category.Id == id).ToListAsync();

            if (CProducts == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
