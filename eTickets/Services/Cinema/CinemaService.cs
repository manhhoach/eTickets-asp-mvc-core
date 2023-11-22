using eTickets.Database;
using eTickets.Generics;

namespace eTickets.Services.Cinema
{
    public class CinemaService : EntityBaseRepository<Models.Cinema>, ICinemaService
    {
        public CinemaService(ApplicationDBContext context) : base(context)
        {
        }
    }
}
