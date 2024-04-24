using Microsoft.AspNetCore.Mvc;

namespace AzureSQLStoreİnstance.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
