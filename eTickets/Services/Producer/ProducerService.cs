using eTickets.Database;
using eTickets.Generics;

namespace eTickets.Services.Producer
{
    public class ProducerService : EntityBaseRepository<Models.Producer>, IProducerService
    {
        public ProducerService(ApplicationDBContext context) : base(context) { }
    }
}
