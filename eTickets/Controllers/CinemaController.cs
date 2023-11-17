using eTickets.Database;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ApplicationDBContext _ctx;
        public CinemaController(ApplicationDBContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var data = _ctx.Cinemas.ToList();
            return View();
        }
    }
}
