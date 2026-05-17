using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string EventType { get; set; }
        public DateTime BookingDato { get; set; }
        public int AmountOfPlates { get; set; }
        public string Location { get; set; }
        public string BookingStatus { get; set; }
        public string Comment { get; set; }
        
        public Customer customer { get; set; }
        public MenuPackage menuPackage { get; set; }

        public Booking() { }

        public Booking(int bookingId, string eventType, DateTime bookingDato, int amountOfPlates, string location, string bookingStatus, string comment, Customer customer, MenuPackage menuPackage)
        {
            BookingId = bookingId;
            EventType = eventType;
            BookingDato = bookingDato;
            AmountOfPlates = amountOfPlates;
            Location = location;
            BookingStatus = bookingStatus;
            Comment = comment;
            this.customer = customer;
            this.menuPackage = menuPackage;
        }

         
    }
}
