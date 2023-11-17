using eTickets.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly ApplicationDBContext _ctx;
        public ProducerController(ApplicationDBContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _ctx.Producers.ToListAsync();
            return View(data);
        }
    }
}
