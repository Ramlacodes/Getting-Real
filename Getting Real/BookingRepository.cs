using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class BookingRepository
    {
        private List<Booking> bookings = new List<Booking>();

        public void AddBooking(Booking booking)
        {
            bookings.Add(booking);
        }

        public List<Booking> GetAllBookings()
        {
            return bookings;
        }

    }
}
