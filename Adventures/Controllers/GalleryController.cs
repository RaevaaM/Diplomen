using Microsoft.AspNetCore.Mvc;

namespace Adventures.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
