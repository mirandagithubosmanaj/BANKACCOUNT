using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace BankAccount.Pages.User
{
    [AllowAnonymous]
    public class LoginUserModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        private IAuthService _authService {  get; set; }

        public LoginUserModel(IAuthService authService)
        {
            _authService = authService;
        }

        public class InputModel
        {
            [Required]
            public string Username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public async Task<IActionResult> OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync("Cookies");
                return LocalRedirect("~/");
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var tokenObject = await _authService.LoginAsync(Input.Username, Input.Password);
                    if (tokenObject != null)
                    {
                        var claimsIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        claimsIdentity.AddClaim(new Claim("Token", tokenObject.Token));
                        var principal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return LocalRedirect("~/");
                    }
                    TempData["ErrorMessage"] = "Wrong. Do it again.";
                }
                return Page();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error 404";
                return Page();
            }
        }
    }
}
