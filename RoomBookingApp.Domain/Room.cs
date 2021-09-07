using System.Collections.Generic;

namespace RoomBookingApp.Domain
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<RoomBooking> RoomBookings { get; set; }
    }
}