using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneShop.DB;
using PhoneShop.Models;

namespace PhoneShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private PhoneShopDbContext db;

        public ProductController(PhoneShopDbContext context)
        {
            db = db;
        }

        public async Task<IActionResult> Index()
        {
            var prods = await db
                .Products
                .Include(p=>p.Category)
                .ToListAsync();
            return View(prods);
        }

        public async Task<IActionResult> Create()
        {
            var cates = await db.Categories 
                .Select(c => new SelectListItem(
                    c.Name, c.Id.ToString())).ToListAsync();
            ViewBag.Categories = cates;
            return View();
        }
    }
}