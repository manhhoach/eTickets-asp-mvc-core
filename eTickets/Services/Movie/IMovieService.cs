using eTickets.Data;
using eTickets.ViewModels.Movie;

namespace eTickets.Services.Movie
{
    public interface IMovieService : IEntityBaseRepository<Models.Movie>
    {
        Task<Models.Movie> GetDetailsById(int id);
        Task<DropdownCreateMovieVM> GetDropdownCreateMovie();
        Task CreateMovie(CreateMovieVM createMovieVM);
        Task UpdateMovie(EditMovieVM updateMovieVM);
    }
}
