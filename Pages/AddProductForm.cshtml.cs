using iapCoursework2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace iapCoursework2.Pages
{
    //[Authorize(Roles = "Admin")]
    public class AddProductFormModel : PageModel
    {
        public readonly AppDataContext _db;
        public AddProductFormModel(AppDataContext db) {
            _db = db;
        }
        [BindProperty]
        public Product Product { get; set; }
        public SelectList Categories { get; set; }

        public async Task OnGetAsync()
        {
            Categories = new SelectList(await _db.Categories.ToListAsync(), "Id", "Name");
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var categoryId = Product.Category.Id;
            var category = await _db.Categories.Where(c => c.Id == categoryId).FirstOrDefaultAsync();

            Product.Category = category;
            ModelState.Remove("Product.Category.Name");
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Products.Add(Product);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

