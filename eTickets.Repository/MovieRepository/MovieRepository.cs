using eTickets.Model;
using eTickets.Model.Models;
using eTickets.Repository.Common;

namespace eTickets.Repository.MovieRepository
{
    public class MovieRepository : EntityBaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
