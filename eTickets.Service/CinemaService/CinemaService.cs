using eTickets.Common;
using eTickets.Model;
using eTickets.Models;

namespace eTickets.Service.CinemaService
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(ApplicationDBContext context) : base(context)
        {
        }
    }
}
