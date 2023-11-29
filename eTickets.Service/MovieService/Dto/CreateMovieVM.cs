using eTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Service.MovieService.Dto
{
    public class CreateMovieVM
    {
        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Sumary { get; set; }

        public double Price { get; set; }

        [Display(Name = "Movie image")]
        [Required(ErrorMessage = "Image is required")]
        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        public List<int> ActorIds { get; set; }

        public int CinemaId { get; set; }

        public int ProducerId { get; set; }

    }
}
