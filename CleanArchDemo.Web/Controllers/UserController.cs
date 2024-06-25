using CleanArchDemo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchDemo.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async  Task<IActionResult> Index()
        {
            try
            {
                var users = await _userService.GetAllAsync();
                return View(users);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
