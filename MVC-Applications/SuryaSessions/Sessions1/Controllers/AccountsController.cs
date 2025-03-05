using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Sessions1.Models;

namespace Sessions1.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountsController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser>signInManager) 
        { 
        
            _userManager = userManager;           _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]  
        public async Task<IActionResult> RegisterUser(RegisterViewModel model)
        {
            IdentityUser user = new IdentityUser { UserName = model.Email, Email = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                ViewBag.msg = "User Registered Successfully";
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        [HttpGet]   
        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]  
        public async Task<IActionResult> LoginUser(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                HttpContext.Session.SetString("UserName", model.Email);
                return RedirectToAction("dashboard");
                
            }
            else
            {
                ViewBag.msg = "Invalid Input Credentials";
            }

            return View();
        }
        [Authorize]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                string UserName = HttpContext.Session.GetString("UserName");
                ViewBag.msg = $"{UserName} Login Attempt Successful";
            }
            return View();
        }
        
        public async Task<IActionResult> LogOut()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.msg = "Logged Out Successfully";
                await _signInManager.SignOutAsync();
                HttpContext.Session.Clear();
            }
            return View();
        }
    }
}
