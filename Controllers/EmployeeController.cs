using LeThuTrangBTH2.Data;
using LeThuTrangBTH2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeThuTrangBTH2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var epl = await _context.Employees.ToListAsync();
            return View(epl);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee nv)
        {
            if(ModelState.IsValid)
            {
                _context.Add(nv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nv);
        }
    }
}