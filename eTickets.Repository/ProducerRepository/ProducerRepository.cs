using eTickets.Model;
using eTickets.Model.Models;
using eTickets.Repository.Common;

namespace eTickets.Repository.ProducerRepository
{
    public class ProducerRepository : EntityBaseRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(ApplicationDBContext context) : base(context) { }
    }
}
