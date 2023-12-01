using eTickets.Model;
using eTickets.Model.Models;
using eTickets.Repository.Common;

namespace eTickets.Repository.CinemaRepository
{
    public class CinemaRepository : EntityBaseRepository<Cinema>, ICinemaRepository
    {
        public CinemaRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
