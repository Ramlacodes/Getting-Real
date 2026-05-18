using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class Booking
    {
        //Properties fra DCD
        public int BookingId { get; set; }
        public string EventType { get; set; }
        public DateTime BookingDato { get; set; }
        public int AmountOfPlates { get; set; }
        public string Location { get; set; }
        public string BookingStatus { get; set; }
        public string Comment { get; set; }
        
        //Kunde og menupakke bliver knyttet til booking
        public Customer customer { get; set; }
        public MenuPackage menuPackage { get; set; }

        //Tom konstruktør, der gør at vi kan bruge brugerinput til en booking.
        public Booking() { }

        //Konstruktør, der gør at vi kan oprette en booking med alle properties. Den er ikke i brug, da vi bruger den tomme konstruktør og sætter properties via brugerinput.

        //public Booking(int bookingId, string eventType, DateTime bookingDato, int amountOfPlates, string location, string bookingStatus, string comment, Customer customer, MenuPackage menuPackage)
        //{
        //    BookingId = bookingId;
        //    EventType = eventType;
        //    BookingDato = bookingDato;
        //    AmountOfPlates = amountOfPlates;
        //    Location = location;
        //    BookingStatus = bookingStatus;
        //    Comment = comment;
        //    this.customer = customer;
        //    this.menuPackage = menuPackage;
        //}


    }
}
