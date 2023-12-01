using eTickets.Model.Models;
using eTickets.Service.Common;
using eTickets.Service.MovieService.Dto;

namespace eTickets.Service.MovieService
{
    public interface IMovieService : IEntityBaseService<Movie>
    {
        Task<Movie> GetDetailsById(int id);
        //Task<DropdownCreateMovieVM> GetDropdownCreateMovie();
        Task CreateMovie(CreateMovieVM createMovieVM);
        Task UpdateMovie(EditMovieVM updateMovieVM);
    }
}
