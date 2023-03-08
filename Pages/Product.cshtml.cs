using iapCoursework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iapCoursework2.Pages
{
    public class ProductModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
        }
    }
}
