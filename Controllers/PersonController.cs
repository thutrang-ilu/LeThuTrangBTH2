using LeThuTrangBTH2.Data;
using LeThuTrangBTH2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeThuTrangBTH2.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var ucl = await _context.Persons.ToListAsync();
            return View(ucl);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Person ps)
        {
            if(ModelState.IsValid)
            {
                _context.Add(ps);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ps);
        }
    }
}