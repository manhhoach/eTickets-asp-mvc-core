using eTickets.Model.Models;

namespace eTickets.Service.MovieService.Dto
{
    public class DropdownCreateMovieVM
    {
        public DropdownCreateMovieVM()
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }
        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
