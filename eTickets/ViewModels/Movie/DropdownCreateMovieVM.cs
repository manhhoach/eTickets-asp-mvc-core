using eTickets.Models;

namespace eTickets.ViewModels.Movie
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
