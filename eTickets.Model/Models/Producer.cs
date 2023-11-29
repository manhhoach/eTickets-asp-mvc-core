using eTickets.Model.Common;
using System.ComponentModel;

namespace eTickets.Models
{
    public class Producer : EntityBase
    {
        public string Avatar { get; set; }

        [DisplayName("Full name")]
        public string FullName { get; set; }

        [DisplayName("Biography")]
        public string Bio { get; set; }

        public List<Movie>? Movies { get; set; }
    }
}
