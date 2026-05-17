using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class BookingRepository
    {
        // Sti til JSON-filen, hvor bookingerne gemmes.
        private string filePath = "bookings.json";

        // Hent alle bookinger fra JSON-filen. Hvis filen ikke findes, returneres en tom liste.
        public List<Booking> GetAllBookings()
        {
            if (!File.Exists(filePath))
            {
                return new List<Booking>();
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Booking>>(json);
        }


        // Tilføj en ny booking til JSON-filen. Først hentes alle eksisterende bookinger, den nye booking tilføjes, og derefter gemmes den opdaterede liste tilbage i filen.
        public void AddBooking(Booking booking)
        {
            List<Booking> bookings = GetAllBookings();

            bookings.Add(booking);

            string json = JsonSerializer.Serialize(bookings, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, json);
        }


    }
}
