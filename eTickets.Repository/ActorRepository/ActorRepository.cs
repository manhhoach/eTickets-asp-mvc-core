using eTickets.Model;
using eTickets.Model.Models;
using eTickets.Repository.Common;

namespace eTickets.Repository.ActorRepository
{
    public class ActorRepository : EntityBaseRepository<Actor>, IActorRepository
    {
        public ActorRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
