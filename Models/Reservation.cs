using System.ComponentModel.DataAnnotations;

namespace DotnetWithGraphQL.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public int TotalPeople { get; set; }
        public DateTime BookingDateTime { get; set; }
    }
}
