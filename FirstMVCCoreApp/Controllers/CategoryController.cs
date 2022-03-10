using Microsoft.AspNetCore.Mvc;

namespace FirstMVCCoreApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
