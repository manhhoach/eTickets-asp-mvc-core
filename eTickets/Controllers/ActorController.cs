using eTickets.Database;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly ApplicationDBContext _ctx;
        public ActorController(ApplicationDBContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var data = _ctx.Actors.ToList();
            return View(data);
        }
    }
}
