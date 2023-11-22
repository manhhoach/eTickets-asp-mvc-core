using eTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Avatar")]
        [Required]
        public string Avatar { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is required")]
        [MaxLength(50)]
        [MinLength(5)]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
