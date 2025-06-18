using Microsoft.AspNetCore.Mvc;

namespace PAL.Shop.Controllers
{
    public class XShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}