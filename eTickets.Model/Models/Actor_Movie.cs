using eTickets.Model.Common;

namespace eTickets.Model.Models
{
    public class Actor_Movie : EntityBase
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
