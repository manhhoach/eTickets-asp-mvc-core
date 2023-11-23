using eTickets.Services.Movie;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _movieService.GetAll(m => m.Cinema);

            return View("Index", data);
        }
    }
}
