using DotnetWithGraphQL.Data;
using DotnetWithGraphQL.Models;
using DotnetWithGraphQL.Services.Contracts;

namespace DotnetWithGraphQL.Services.Implementations
{
    public class ReservationService : IReservationService
    {

        private readonly ApplicationDBContext _context;

        public ReservationService(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Reservation> GetReservations()
        {
            return _context.Reservations.ToList();
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            return reservation;
        }
    }
}
