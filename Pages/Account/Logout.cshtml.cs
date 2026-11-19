using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspnetWebApp.Models;

namespace aspnetWebApp.Pages.Account;

public class LogoutModel : PageModel {
    private readonly SignInManager<ApplicationUser> _signInManager;
    public LogoutModel(SignInManager<ApplicationUser> signInManager) {
        _signInManager = signInManager;
    }

    public void OnGet() {}

    public async Task<IActionResult> OnGetAsync() {
        await _signInManager.SignOutAsync();
        return RedirectToPage("/Index");
    }
}