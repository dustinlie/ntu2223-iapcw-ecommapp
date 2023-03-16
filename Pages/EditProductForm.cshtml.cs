using iapCoursework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iapCoursework2.Pages
{
    public class EditProductFormModel : PageModel
    {
        public readonly AppDataContext _db;
        public EditProductFormModel(AppDataContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public Product Product { get; set; }
        public void OnGet()
        {
            Product = _db.Products.Find(Id);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            _db.Products.Update(Product);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
