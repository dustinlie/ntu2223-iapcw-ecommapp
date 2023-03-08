using iapCoursework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iapCoursework2.Pages
{
    public class AddProductFormModel : PageModel
    {
        public readonly AppDataContext _db;
        public AddProductFormModel(AppDataContext db) {
            _db = db;
        }
        public Product Product { get; set; }
        public void OnGet()
        {
        }
    }
}
