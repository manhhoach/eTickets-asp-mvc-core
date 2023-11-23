using eTickets.Database;
using eTickets.Generics;

namespace eTickets.Services.Movie
{
    public class MovieService : EntityBaseRepository<Models.Movie>, IMovieService
    {
        public MovieService(ApplicationDBContext context) : base(context)
        {
        }
    }
}
