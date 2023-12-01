//using eTickets.Models;
//using eTickets.Service.ActorService;
//using Microsoft.AspNetCore.Mvc;

//namespace eTickets.Controllers
//{
//    public class ActorController : Controller
//    {
//        private readonly IActorService _actorService;
//        public ActorController(IActorService actorService)
//        {
//            _actorService = actorService;
//        }
//        public async Task<IActionResult> Index()
//        {
//            var data = await _actorService.GetAll();
//            return View(data);
//        }

//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create([Bind("FullName, Avatar, Bio")] Actor actor)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(actor);
//            }
//            await _actorService.Add(actor);
//            return RedirectToAction("Index");

//        }

//        public async Task<IActionResult> Details(int id)
//        {
//            Actor actor = await _actorService.GetById(id);
//            if (actor != null)
//                return View(actor);
//            return View("NotFound");
//        }

//        public async Task<IActionResult> Edit(int id)
//        {
//            Actor actor = await _actorService.GetById(id);
//            if (actor == null)
//            {
//                return View("NotFound");
//            }
//            return View(actor);

//        }
//        [HttpPost]
//        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, Avatar, Bio")] Actor actor)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(actor);
//            }
//            await _actorService.Update(id, actor);
//            return RedirectToAction(nameof(Index));

//        }

//        public async Task<IActionResult> Delete(int id)
//        {
//            Actor actor = await _actorService.GetById(id);
//            if (actor == null)
//            {
//                return View("NotFound");
//            }
//            return View(actor);

//        }
//        [HttpPost, ActionName("Delete")]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            await _actorService.Delete(id);
//            return RedirectToAction(nameof(Index));

//        }
//    }
//}
