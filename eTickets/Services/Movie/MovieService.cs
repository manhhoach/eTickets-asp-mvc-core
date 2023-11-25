using eTickets.Database;
using eTickets.Generics;
using eTickets.Models;
using eTickets.ViewModels.Movie;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Services.Movie
{
    public class MovieService : EntityBaseRepository<Models.Movie>, IMovieService
    {
        private readonly ApplicationDBContext _context;
        public MovieService(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task CreateMovie(CreateMovieVM createMovieVM)
        {
            var movie = new Models.Movie()
            {
                Description = createMovieVM.Description,
                CinemaId = createMovieVM.CinemaId,
                EndDate = createMovieVM.EndDate,
                ImageUrl = createMovieVM.ImageUrl,
                MovieCategory = createMovieVM.MovieCategory,
                Name = createMovieVM.Name,
                Price = createMovieVM.Price,
                ProducerId = createMovieVM.ProducerId,
                StartDate = createMovieVM.StartDate,
                Sumary = createMovieVM.Sumary
            };
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            List<Actor_Movie> actor_movie = new List<Actor_Movie>();
            foreach (var item in createMovieVM.ActorIds)
            {
                actor_movie.Add(new Actor_Movie()
                {
                    ActorId = item,
                    MovieId = movie.Id
                });
            }
            await _context.Actors_Movies.AddRangeAsync(actor_movie);
            await _context.SaveChangesAsync();
        }

        public async Task<DropdownCreateMovieVM> GetDropdownCreateMovie()
        {
            var DropdownData = new DropdownCreateMovieVM();
            DropdownData.Actors = await _context.Actors.OrderBy(a => a.FullName).ToListAsync();
            DropdownData.Producers = await _context.Producers.OrderBy(p => p.FullName).ToListAsync();
            DropdownData.Cinemas = await _context.Cinemas.OrderBy(c => c.Name).ToListAsync();

            return DropdownData;

        }

        public async Task<Models.Movie> GetDetailsById(int id)
        {
            var movieDetails = await _context.Movies
                .Include(m => m.Cinema)
                .Include(m => m.Producer)
                .Include(m => m.Actors_Movies).ThenInclude(am => am.Actor)
                .FirstOrDefaultAsync(m => m.Id == id);
            return movieDetails;
        }

        public async Task UpdateMovie(EditMovieVM updateMovieVM)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == updateMovieVM.Id);
            if (movie != null)
            {
                movie.Description = updateMovieVM.Description;
                movie.CinemaId = updateMovieVM.CinemaId;
                movie.EndDate = updateMovieVM.EndDate;
                movie.ImageUrl = updateMovieVM.ImageUrl;
                movie.MovieCategory = updateMovieVM.MovieCategory;
                movie.Name = updateMovieVM.Name;
                movie.Price = updateMovieVM.Price;
                movie.ProducerId = updateMovieVM.ProducerId;
                movie.StartDate = updateMovieVM.StartDate;
                movie.Sumary = updateMovieVM.Sumary;
                _context.Movies.Update(movie);
                await _context.SaveChangesAsync();

                var existingActor = await _context.Actors_Movies.Where(am => am.MovieId == movie.Id).ToListAsync();
                _context.Actors_Movies.RemoveRange(existingActor);
                await _context.SaveChangesAsync();


                List<Actor_Movie> actor_movie = new List<Actor_Movie>();
                foreach (var item in updateMovieVM.ActorIds)
                {
                    actor_movie.Add(new Actor_Movie()
                    {
                        ActorId = item,
                        MovieId = movie.Id
                    });
                }
                await _context.Actors_Movies.AddRangeAsync(actor_movie);
                await _context.SaveChangesAsync();
            }



        }
    }
}
