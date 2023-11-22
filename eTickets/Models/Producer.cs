using eTickets.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Avatar { get; set; }
        [DisplayName("Full name")]
        public string FullName { get; set; }
        [DisplayName("Biography")]
        public string Bio { get; set; }

        public List<Movie>? Movies { get; set; }
    }
}
