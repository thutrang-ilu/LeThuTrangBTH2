using LeThuTrangBTH2.Data;
using LeThuTrangBTH2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeThuTrangBTH2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var vl = await _context.Customers.ToListAsync();
            return View(vl);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer KH)
        {
            if(ModelState.IsValid)
            {
                _context.Add(KH);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(KH);
        }
    }
}