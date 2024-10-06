using MessLogger.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MessLogger.Controllers.Visitor
{
    public class VisitorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VisitorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var visitor =await _db.Visitors.ToListAsync();
            return View(visitor);
        }

         

    }
}
