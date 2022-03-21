using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace AuthandAuthorization.Pages.Account
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
         {
        }
        public async Task<IActionResult> OnPostAsync(){
            if (!ModelState.IsValid)
                return Page();
            if (Credential.UserName == "syed" && Credential.Password == "11223344") {
                var claims = new List<Claim> {
                new Claim(ClaimTypes.Name,"syed"),
                new Claim(ClaimTypes.Email,"syed@gmail.com"),
                new Claim("Department","HR") ,
                new Claim("Admin","true"),
                new Claim("EmployementData","2021-05-01")
                };
                var identity=new ClaimsIdentity(claims,"MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookieAuth",claimsPrincipal);
                return RedirectToPage("/Index");
            }
            return Page(); 

        }
      
    }
    public class Credential { 
        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
