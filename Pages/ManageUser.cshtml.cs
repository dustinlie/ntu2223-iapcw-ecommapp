using iapCoursework2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace iapCoursework2.Pages
{
    public class ManageUserModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public ManageUserModel(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public List<IdentityRole> Roles { get; set; }
        public List<AppUser> Users { get; set; }

        [BindProperty]
        public string roleName { get;  set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Roles = await _roleManager.Roles.ToListAsync();
            Users = await _userManager.Users.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
                return RedirectToPage("/ManageUser");
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }


}
