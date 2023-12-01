using eTickets.Model.Models;
using eTickets.Repository.ActorMovieRepository;
using eTickets.Service.Common;

namespace eTickets.Service.ActorMovieService
{
    public class ActorMovieService : EntityBaseService<Actor_Movie>, IActorMovieService
    {
        private readonly IActorMovieRepository _actorMovieRepository;
        public ActorMovieService(IActorMovieRepository actorMovieRepository) : base(actorMovieRepository)
        {
            _actorMovieRepository = actorMovieRepository;
        }
    }
}
