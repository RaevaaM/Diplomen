using Adventures.Models;
using Microsoft.AspNetCore.Mvc;

namespace Adventures.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            List<Item> items = new List<Item>()
            {
                new Item() {ItemId=1, ItemType="something", Description="hdfn"},
 new Item() {ItemId=1, ItemType="something", Description="hdfn"}
            };
            return View(items);
        }
    }
}
