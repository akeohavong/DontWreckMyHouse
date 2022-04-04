

namespace DontWreckMyHouse.Core.DTO
{
    public class Reservation
    {
        public Host Host { get; set; }
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guest Guest { get; set; }

   
    }
}
