using FMS_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FMS_Project.Controllers
{
    public class ServiceChecksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceChecksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServiceChecks
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ServiceChecks.Include(sc => sc.Fridge);
            return View(await applicationDbContext.ToListAsync());
        }

        // Other actions: Details, Create, Edit, Delete
        // ...
    }
}
