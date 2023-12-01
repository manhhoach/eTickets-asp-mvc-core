using eTickets.Model;
using eTickets.Model.Models;
using eTickets.Repository.Common;

namespace eTickets.Repository.ActorMovieRepository
{
    public class ActorMovieRepository : EntityBaseRepository<Actor_Movie>, IActorMovieRepository
    {
        public ActorMovieRepository(ApplicationDBContext context) : base(context) { }
    }
}
