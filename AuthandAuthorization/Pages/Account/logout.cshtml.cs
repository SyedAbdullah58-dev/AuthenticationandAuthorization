using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthandAuthorization.Pages.Account
{
    public class logoutModel : PageModel
    {
        public async Task<IActionResult> OnPostAsync()
        {
            HttpContext.SignOutAsync("MyCookieAuth");
            return RedirectToPage("/Index");
        }
    }
}
