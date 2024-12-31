using Microsoft.AspNetCore.Mvc;

namespace ZeyadInHome.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
