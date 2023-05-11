using Adventures.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Diagnostics;

namespace Adventures.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ItemContext _context = new ItemContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Booking()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Video()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ATVpage()
        {
            return View();
        }
        public IActionResult BalloonPage()
        {
            return View();
        }
        public IActionResult BungeePage()
        {
            return View();
        }
        public IActionResult ClimbPage()
        {
            return View();
        }
        public IActionResult ParaPage()
        {
            return View();
        }
        public IActionResult RaftingPage()
        {
            return View();
        }
        public IActionResult SkydivePage()
        {
            return View();
        }
        public IActionResult SnowPage()
        {
            return View();
        }
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    //var item = await _context.Items
        //    //    .Include(i => i.Name)
        //    //        .Include(e=>e.CreatedOn)
        //    //    .AsNoTracking()
        //    //    .FirstOrDefaultAsync(m => m.Id == id);

        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(item);
        //}

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create(
        //[Bind("CreatedOn,Description,Name")] Item item)
        //    {
        //        try
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                _context.Add(item);
        //                await _context.SaveChangesAsync();
        //                return RedirectToAction(nameof(Index));
        //            }
        //        }
        //        catch (DbUpdateException /* ex */)
        //        {
        //            //Log the error (uncomment ex variable name and write a log.
        //            ModelState.AddModelError("", "Unable to save changes. " +
        //                "Try again, and if the problem persists " +
        //                "see your system administrator.");
        //        }
        //        return View(item);
        //    }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}