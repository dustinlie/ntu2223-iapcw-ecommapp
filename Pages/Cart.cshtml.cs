using iapCoursework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace iapCoursework2.Pages
{
    public class CartModel : PageModel
    {
        public readonly AppDataContext _db;

        public CartModel(AppDataContext db)
        {
            _db = db;
        }

        public IList<Cart> CartItems { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            CartItems = await _db.CartItems.ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnGetDeleteAsync(int id)
        {
            var cartItem = await _db.CartItems.FindAsync(id);

            if (cartItem != null)
            {
                _db.CartItems.Remove(cartItem);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("/Cart");
        }
    }
}
