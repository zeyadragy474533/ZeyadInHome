using Microsoft.AspNetCore.Mvc;

namespace ZeyadInHome.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
