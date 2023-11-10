using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopIvy.Models;

namespace ShopIvy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHttpContextAccessor httpContext;
    private readonly UserManager<Users> userManager;

    public HomeController(ILogger<HomeController> logger,IHttpContextAccessor httpContext,UserManager<Users> userManager)
    {
        _logger = logger;
        this.httpContext = httpContext;
        this.userManager = userManager;
    }

    public IActionResult Admin(){
        return View();
    }
    public IActionResult Customer(){
        return View();
    }
    public async Task<IActionResult> IndexAsync()
    {   
                    var principal = httpContext.HttpContext.User;
                    string email=userManager.GetUserName(principal);
                    if(email is not null){
                        var user = await userManager.FindByEmailAsync(email);
                        var roles = await userManager.GetRolesAsync(user);
                        if (roles.Contains("Admin"))
                        {
                            return RedirectToAction("Admin", "Home");
                        }
                        else if (roles.Contains("User"))
                        {
                            return RedirectToAction("Customer", "Home");
                        }
                    }     
        return RedirectToRoute(new { area = "Identity", page = "/Account/Login" });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
