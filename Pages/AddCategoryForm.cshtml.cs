using iapCoursework2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace iapCoursework2.Pages
{
    [Authorize(Roles = "Admin")]
    public class AddCategoryFormModel : PageModel
    {
        public readonly AppDataContext _db;

        public AddCategoryFormModel(AppDataContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            Category.Products = new List<Product>();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Categories.Add(Category);
            await _db.SaveChangesAsync();
            _db.Dispose();

            return RedirectToPage("./Index");
        }
    }
}