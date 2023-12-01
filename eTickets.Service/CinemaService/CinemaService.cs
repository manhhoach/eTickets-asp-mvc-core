using eTickets.Model.Models;
using eTickets.Repository.CinemaRepository;
using eTickets.Service.Common;

namespace eTickets.Service.CinemaService
{
    public class CinemaService : EntityBaseService<Cinema>, ICinemaService
    {
        private readonly ICinemaRepository _cinemaRepository;
        public CinemaService(ICinemaRepository cinemaRepository) : base(cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }
    }
}
