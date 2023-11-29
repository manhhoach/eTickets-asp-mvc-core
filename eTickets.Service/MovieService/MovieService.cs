

using eTickets.Common;
using eTickets.Model;
using eTickets.Models;
using eTickets.Service.MovieService.Dto;
using System.Linq.Expressions;

namespace eTickets.Service.MovieService
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
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
                List<Actor_Movie> newActor = updateMovieVM.ActorIds.Select(actorId => new Actor_Movie()
                {
                    MovieId = movie.Id,
                    ActorId = actorId,
                }).ToList();

                var RemovedActor = existingActor.Except(newActor);
                var CreatedActor = newActor.Except(existingActor);
                _context.Actors_Movies.RemoveRange(RemovedActor);
                await _context.Actors_Movies.AddRangeAsync(CreatedActor);
                await _context.SaveChangesAsync();
            }

        }

        Task<IEnumerable<Actor>> IEntityBaseRepository<Actor>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Actor>> GetAll(params Expression<Func<Actor, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Actor>> IEntityBaseRepository<Actor>.GetAllNoTracking()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Actor>> GetAllNoTracking(params Expression<Func<Actor, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        IQueryable<Actor> IEntityBaseRepository<Actor>.GetAllAsQueryable()
        {
            throw new NotImplementedException();
        }

        Task<Actor> IEntityBaseRepository<Actor>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetById(int id, params Expression<Func<Actor, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> FindByCondition(Expression<Func<Actor, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Add(Actor t)
        {
            throw new NotImplementedException();
        }

        public Task AddRange(IEnumerable<Actor> list)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Actor t)
        {
            throw new NotImplementedException();
        }
    }
}
