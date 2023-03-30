using iapCoursework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace iapCoursework2.Pages
{
    public class IndividualProductModel : PageModel
    {
        public readonly AppDataContext _db;

        public IndividualProductModel(AppDataContext db)
        {
            _db = db;
        }
        public Product Product { get; set; }
        public string CategoryName { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Product = await _db.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
            CategoryName = await _db.Categories.Where(c => c.Id == Product.Category.Id).Select(c => c.Name).FirstOrDefaultAsync();

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id, string name, decimal price)
        {

                var product = await _db.Products.FindAsync(id);

                if (product == null)
                {
                    return NotFound();
                }

                var cartItem = await _db.CartItems.FirstOrDefaultAsync(c => c.Id == id);

                if (cartItem == null)
                {
                    cartItem = new Cart
                    {
                        Id = product.Id,
                        Name = name,
                        Price = price,
                        Quantity = 1
                    };

                    _db.CartItems.Add(cartItem);
                }
                else
                {
                    cartItem.Quantity++;
                }

                await _db.SaveChangesAsync();

                return RedirectToPage("Cart");
            
        }
    }
}
