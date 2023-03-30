using iapCoursework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace iapCoursework2.Pages
{
    public class SearchModel : PageModel
    {
        public readonly AppDataContext _db;
        public SearchModel(AppDataContext db)
        {
            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public IQueryable<Product> ProductsQueryable { get; set; }

        public IList<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<Product> products = _db.Products;

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                products = products.Where(p => p.Name.Contains(SearchTerm) || p.Description.Contains(SearchTerm));
            }

            Products = await products.ToListAsync();
        }
    }
}
