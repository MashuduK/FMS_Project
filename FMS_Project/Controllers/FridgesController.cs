using FMS_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FMS_Project.Controllers
{
    public class FridgesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FridgesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Fridges
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Fridges.Include(f => f.Customer);
            return View(await applicationDbContext.ToListAsync());
        }

        // Other actions: Details, Create, Edit, Delete
        // ...
    }
}
