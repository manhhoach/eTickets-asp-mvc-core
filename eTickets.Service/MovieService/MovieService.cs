using eTickets.Model.Models;
using eTickets.Repository.MovieRepository;
using eTickets.Service.Common;
using eTickets.Service.MovieService.Dto;

namespace eTickets.Service.MovieService
{
    public class MovieService : EntityBaseService<Movie>, IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository) : base(movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task CreateMovie(CreateMovieVM createMovieVM)
        {
            //var movie = new Movie()
            //{
            //    Description = createMovieVM.Description,
            //    CinemaId = createMovieVM.CinemaId,
            //    EndDate = createMovieVM.EndDate,
            //    ImageUrl = createMovieVM.ImageUrl,
            //    MovieCategory = createMovieVM.MovieCategory,
            //    Name = createMovieVM.Name,
            //    Price = createMovieVM.Price,
            //    ProducerId = createMovieVM.ProducerId,
            //    StartDate = createMovieVM.StartDate,
            //    Sumary = createMovieVM.Sumary
            //};
            //await _movieRepository.Add(movie);
            //List<Actor_Movie> actor_movie = new List<Actor_Movie>();
            //foreach (var item in createMovieVM.ActorIds)
            //{
            //    actor_movie.Add(new Actor_Movie()
            //    {
            //        ActorId = item,
            //        MovieId = movie.Id
            //    });
            //}
            //await _context.Actors_Movies.AddRangeAsync(actor_movie);
            //await _context.SaveChangesAsync();
        }

        //public async Task<DropdownCreateMovieVM> GetDropdownCreateMovie()
        //{
        //    var DropdownData = new DropdownCreateMovieVM();
        //    DropdownData.Actors = await _context.Actors.OrderBy(a => a.FullName).ToListAsync();
        //    DropdownData.Producers = await _context.Producers.OrderBy(p => p.FullName).ToListAsync();
        //    DropdownData.Cinemas = await _context.Cinemas.OrderBy(c => c.Name).ToListAsync();
        //    return DropdownData;

        //}

        public async Task<Movie> GetDetailsById(int id)
        {
            var movieDetails = await _movieRepository.GetById(id, m => m.Cinema, m => m.Producer, m => m.Actors_Movies.Select(am => am.Actor));
            return movieDetails;
        }

        public async Task UpdateMovie(EditMovieVM updateMovieVM)
        {
            //var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == updateMovieVM.Id);
            //if (movie != null)
            //{
            //    movie.Description = updateMovieVM.Description;
            //    movie.CinemaId = updateMovieVM.CinemaId;
            //    movie.EndDate = updateMovieVM.EndDate;
            //    movie.ImageUrl = updateMovieVM.ImageUrl;
            //    movie.MovieCategory = updateMovieVM.MovieCategory;
            //    movie.Name = updateMovieVM.Name;
            //    movie.Price = updateMovieVM.Price;
            //    movie.ProducerId = updateMovieVM.ProducerId;
            //    movie.StartDate = updateMovieVM.StartDate;
            //    movie.Sumary = updateMovieVM.Sumary;
            //    _context.Movies.Update(movie);
            //    await _context.SaveChangesAsync();

            //    var existingActor = await _context.Actors_Movies.Where(am => am.MovieId == movie.Id).ToListAsync();
            //    List<Actor_Movie> newActor = updateMovieVM.ActorIds.Select(actorId => new Actor_Movie()
            //    {
            //        MovieId = movie.Id,
            //        ActorId = actorId,
            //    }).ToList();

            //    var RemovedActor = existingActor.Except(newActor);
            //    var CreatedActor = newActor.Except(existingActor);
            //    _context.Actors_Movies.RemoveRange(RemovedActor);
            //    await _context.Actors_Movies.AddRangeAsync(CreatedActor);
            //    await _context.SaveChangesAsync();
            //}

        }
    }
}
