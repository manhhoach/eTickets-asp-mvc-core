using eTickets.Common;
using eTickets.Model;
using eTickets.Models;

namespace eTickets.Service.ActorService
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(ApplicationDBContext context) : base(context)
        {

        }

    }
}
