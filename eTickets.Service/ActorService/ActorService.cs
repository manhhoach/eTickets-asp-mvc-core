
using eTickets.Model.Models;
using eTickets.Repository.ActorRepository;
using eTickets.Service.Common;

namespace eTickets.Service.ActorService
{
    public class ActorService : EntityBaseService<Actor>, IActorService
    {
        private readonly IActorRepository _actorRepository;
        public ActorService(IActorRepository actorRepository) : base(actorRepository)
        {
            _actorRepository = actorRepository;
        }

    }
}
