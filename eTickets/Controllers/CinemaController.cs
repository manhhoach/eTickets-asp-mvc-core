using eTickets.Models;
using eTickets.Services.Cinema;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService _cinemaService;
        public CinemaController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _cinemaService.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var data = await _cinemaService.GetById(id);
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _cinemaService.Add(cinema);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Edit(int id)
        {
            Cinema data = await _cinemaService.GetById(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return View(data);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cinema data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }
            await _cinemaService.Update(id, data);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            Cinema data = await _cinemaService.GetById(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return View(data);

        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _cinemaService.SoftDelete(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
