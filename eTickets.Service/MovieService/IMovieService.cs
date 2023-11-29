using eTickets.Common;
using eTickets.Models;
using eTickets.Service.MovieService.Dto;

namespace eTickets.Service.MovieService
{
    public interface IMovieService : IEntityBaseRepository<Actor>
    {
        Task<Models.Movie> GetDetailsById(int id);
        Task<DropdownCreateMovieVM> GetDropdownCreateMovie();
        Task CreateMovie(CreateMovieVM createMovieVM);
        Task UpdateMovie(EditMovieVM updateMovieVM);
    }
}
