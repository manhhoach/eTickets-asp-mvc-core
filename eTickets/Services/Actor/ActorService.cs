using eTickets.Database;
using eTickets.Generics;

namespace eTickets.Services.Actor
{
    public class ActorService : EntityBaseRepository<Models.Actor>, IActorService
    {
        public ActorService(ApplicationDBContext context) : base(context)
        {

        }

    }
}
