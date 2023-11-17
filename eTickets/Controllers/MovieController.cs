using eTickets.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDBContext _ctx;
        public MovieController(ApplicationDBContext ctx)
        {
            _ctx = ctx;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _ctx.Movies.ToListAsync();
            return View();
        }
    }
}
