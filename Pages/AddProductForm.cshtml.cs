using iapCoursework2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iapCoursework2.Pages
{
    [Authorize(Roles = "Admin")]
    public class AddProductFormModel : PageModel
    {
        public readonly AppDataContext _db;
        public AddProductFormModel(AppDataContext db) {
            _db = db;
        }
        [BindProperty]
        public Product Product { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Products.Add(Product);
            await _db.SaveChangesAsync();
            _db.Dispose();

            return RedirectToPage("./Index");
        }
    }
}

