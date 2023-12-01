//using eTickets.Services.Movie;
//using eTickets.ViewModels.Movie;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace eTickets.Controllers
//{
//    public class MovieController : Controller
//    {
//        private readonly IMovieService _movieService;
//        public MovieController(IMovieService movieService)
//        {
//            _movieService = movieService;
//        }


//        public async Task<IActionResult> Index()
//        {
//            var data = await _movieService.GetAll(m => m.Cinema);

//            return View("Index", data);
//        }

//        public async Task<IActionResult> Filter(string searchString)
//        {
//            var data = await _movieService.GetAll(m => m.Cinema);
//            if (!string.IsNullOrEmpty(searchString))
//            {
//                data = data.Where(m => m.Name.ToLower().Contains(searchString.ToLower()));
//            }
//            return View("Index", data);

//        }

//        public async Task<IActionResult> Details(int id)
//        {
//            var data = await _movieService.GetDetailsById(id);
//            return View(data);
//        }

//        public async Task<IActionResult> Create()
//        {
//            var DropdownData = await _movieService.GetDropdownCreateMovie();
//            ViewBag.Cinemas = new SelectList(DropdownData.Cinemas, "Id", "Name");
//            ViewBag.Actors = new SelectList(DropdownData.Actors, "Id", "FullName");
//            ViewBag.Producers = new SelectList(DropdownData.Producers, "Id", "FullName");
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create(CreateMovieVM createMovieVM)
//        {
//            if (ModelState.IsValid)
//            {
//                await _movieService.CreateMovie(createMovieVM);
//                return RedirectToAction(nameof(Index));
//            }
//            return View(createMovieVM);

//        }

//        public async Task<IActionResult> Edit(int id)
//        {
//            //var movie = await _movieService.GetDetailsById(id);
//            var movie = await _movieService.GetById(id, m => m.Actors_Movies);
//            if (movie == null)
//            {
//                return View("NotFound");
//            }
//            var DropdownData = await _movieService.GetDropdownCreateMovie();
//            ViewBag.Cinemas = new SelectList(DropdownData.Cinemas, "Id", "Name");
//            ViewBag.Actors = new SelectList(DropdownData.Actors, "Id", "FullName");
//            ViewBag.Producers = new SelectList(DropdownData.Producers, "Id", "FullName");

//            var editMovie = new EditMovieVM()
//            {
//                Id = movie.Id,
//                Description = movie.Description,
//                CinemaId = movie.CinemaId,
//                EndDate = movie.EndDate,
//                ImageUrl = movie.ImageUrl,
//                MovieCategory = movie.MovieCategory,
//                Name = movie.Name,
//                Price = movie.Price,
//                ProducerId = movie.ProducerId,
//                StartDate = movie.StartDate,
//                Sumary = movie.Sumary,
//                ActorIds = movie.Actors_Movies.Select(am => am.ActorId).ToList()
//            };


//            return View(editMovie);

//        }
//        [HttpPost]
//        public async Task<IActionResult> Edit(int id, EditMovieVM editMovieVM)
//        {
//            if (id != editMovieVM.Id)
//            {
//                return View("NotFound");
//            }
//            if (ModelState.IsValid)
//            {
//                await _movieService.UpdateMovie(editMovieVM);
//                return RedirectToAction(nameof(Index));
//            }
//            return View(editMovieVM);

//        }
//    }
//}
