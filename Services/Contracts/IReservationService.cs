using DotnetWithGraphQL.Models;

namespace DotnetWithGraphQL.Services.Contracts
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
