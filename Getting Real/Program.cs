using System.Text;
using System.Text.Json;

namespace Getting_Real
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool isRunning = true;

            // Opret instanser af repository og calculator klasser
            BookingRepository bookingRepo = new BookingRepository();
            MenuPackageRepository menuRepo = new MenuPackageRepository();
            PriceCalculator calculator = new PriceCalculator();

            List<Customer> customers = new List<Customer>();

            // Tilføj menupakker
            menuRepo.AddMenuPackage(new MenuPackage(1, "Casablanca Kebab Wrap", 135, "Crispy Wrap med Kebab, Salat og Husets Dressing"));
            menuRepo.AddMenuPackage(new MenuPackage(2, "Fez Falafel Wrap", 135, "Crispy Wrap med Falafel, Salat og Husets Dressing"));
            menuRepo.AddMenuPackage(new MenuPackage(3, "Marrakech Chicken Wrap", 135, "Crispy Wrap med Kylling, Salat og Husets Dressing"));


            
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("********************************");
                Console.WriteLine(" Marrakech Street Food System ");
                Console.WriteLine("********************************");

                Console.WriteLine("1. Opret kunde");
                Console.WriteLine("2. Opret bookingforespørgsel");
                Console.WriteLine("3. Vis menupakker");
                Console.WriteLine("4. Afslut");
                Console.WriteLine("\nKUN FOR ADMIN");
                Console.WriteLine("5. Se alle bookingforespørgsler");

                Console.Write("\nVælg et nummer: ");

                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":

                        Console.Clear();

                        Console.WriteLine("Opret kunde");

                        Console.WriteLine("\nIndtast navn:");
                        string navn = Console.ReadLine();

                        Console.WriteLine("Indtast email:");
                        string email = Console.ReadLine();

                        Console.WriteLine("Indtast telefonnummer:");

                        int tlf;
                        // Validering for at sikre, at input er et gyldigt heltal
                        while (!int.TryParse(Console.ReadLine(), out tlf))
                        {
                            Console.WriteLine("Ugyldigt input! Indtast et tal:");
                        }

                        // Opret kunde og tilføj til listen
                        Customer customer1 = new Customer(navn, email, tlf);
                        customers.Add(customer1);

                        Console.WriteLine("\nKunde oprettet!");
                        Console.WriteLine($"Navn: {navn}");
                        Console.WriteLine($"Email: {email}");
                        Console.WriteLine($"Telefon: {tlf}");

                        break;

                    case "2":

                        Console.Clear();

                        // --- Vælg kunde ---
                        if (customers.Count == 0)
                        {
                            Console.WriteLine("Ingen kunder oprettet endnu!");
                            break;
                        }

                        Console.WriteLine("\n--- VÆLG KUNDE ---");

                        for (int i = 0; i < customers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {customers[i].CustomerName}");
                        }

                        Console.WriteLine("Opret bookingforespørgsel");

                        Console.Write("Vælg kunde nummer: ");
                        int kundeIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (kundeIndex < 0 || kundeIndex >= customers.Count)
                        {
                            Console.WriteLine("Ugyldigt valg!");
                            break;
                        }
                        //
                        Customer valgtKunde = customers[kundeIndex];

                        // --- Booking info ---
                        Console.WriteLine("\nEvent type: (Eksempel: Bryllup, Fødselsdag, Konfirmation)");
                        string eventType = Console.ReadLine();

                        Console.WriteLine("Indtast dato for event (dd-mm-yyyy):");

                        DateTime bookingDato;

                        while (!DateTime.TryParse(Console.ReadLine(), out bookingDato))
                        {
                            Console.WriteLine("Ugyldig dato! Prøv igen (fx 15-05-2026):");
                        }


                        //Console.WriteLine("Antal kuverter:");
                        //int antal = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Lokation:");
                        string location = Console.ReadLine();

                        Console.WriteLine("Kommentar:");
                        string kommentar = Console.ReadLine();

                        // --- Vælg menu ---
                        Console.WriteLine("\n--- VÆLG MENUPAKKE ---");

                        foreach (var m in menuRepo.GetAllMenuPackages())
                        {
                            Console.WriteLine($"ID: {m.PackageID} - {m.Name} ({m.PricePrPlate} kr \n Indgredienser {m.Ingredients})");
                        }

                        Console.Write("Indtast menu ID: ");
                        int menuId = Convert.ToInt32(Console.ReadLine());

                        // Find den valgte menupakke i repository
                        MenuPackage valgtMenu = menuRepo.GetAllMenuPackages().Find(m => m.PackageID == menuId);

                        if (valgtMenu == null)
                        {
                            Console.WriteLine("Ugyldigt menuvalg!");
                            break;
                        }

                        Console.WriteLine("Antal kuverter:");
                        int antal = Convert.ToInt32(Console.ReadLine());

                        // Pris
                        double pris = calculator.CalculatePrice(valgtMenu.PricePrPlate, antal);

                        // Opret booking
                        Booking booking = new Booking()
                        {
                            BookingId = bookingRepo.GetAllBookings().Count + 1,
                            EventType = eventType,
                            BookingDato = bookingDato,
                            AmountOfPlates = antal,
                            Location = location,
                            BookingStatus = "Oprettet",
                            Comment = kommentar,
                            customer = valgtKunde,
                            menuPackage = valgtMenu
                        };
                        // Tilføj booking til repository
                        bookingRepo.AddBooking(booking);

                        Console.WriteLine("\n Bookingforespørgsel oprettet!");
                        Console.WriteLine("\nTak for din bookingforespørgsel. Du vil modtage en e-mail inden for kort tid med dit bookingnummer.\n Marrakech Street Food vil herefter kontakte dig for den endelige bekræftelse af din booking");
                        Console.WriteLine($"Kunde: {valgtKunde.CustomerName}");
                        Console.WriteLine($"Menu: {valgtMenu.Name}");
                        Console.WriteLine($"Antal kuverter: {antal}");
                        Console.WriteLine($"Event type: {eventType}");
                        Console.WriteLine($"Dato: {bookingDato}");
                        Console.WriteLine($"Lokation: {location}");
                        Console.WriteLine($"Pris: {pris} kr");
                        


                        break;


                    case "3":
                        Console.WriteLine("\n--- MENUPAKKER ---");

                        // Hent alle menupakker fra repository
                        var menuer = menuRepo.GetAllMenuPackages();

                        if (menuer.Count == 0)
                        {
                            Console.WriteLine("Der er ingen menupakker endnu.");
                        }
                        else
                        {
                            // Vis hver menupakke
                            foreach (var m in menuer)
                            {
                                Console.WriteLine("\n----------------------");
                                Console.WriteLine($"ID: {m.PackageID}");
                                Console.WriteLine($"Navn: {m.Name}");
                                Console.WriteLine($"Pris pr kuvert: {m.PricePrPlate} kr");
                                Console.WriteLine($"Ingredienser: {m.Ingredients}");
                            }
                        }

                        break;


                      

                    case "4":

                        Console.WriteLine("\nProgrammet afsluttes...");
                        isRunning = false;

                        break;

                    case "5":
                        Console.WriteLine("\n--- ALLE BOOKINGER ---");
                        
                        var bookings = bookingRepo.GetAllBookings();

                        if (bookings.Count == 0)
                        {
                            Console.WriteLine("Der er ingen bookinger endnu.");
                        }
                        else
                        {
                            foreach (var b in bookings)
                            {
                                Console.WriteLine("\n----------------------");
                                Console.WriteLine($"Booking ID: {b.BookingId}");
                                Console.WriteLine($"Kunde: {b.customer.CustomerName}");
                                Console.WriteLine($"Event: {b.EventType}");
                                Console.WriteLine($"Dato: {b.BookingDato}");
                                Console.WriteLine($"Antal kuverter: {b.AmountOfPlates}");
                                Console.WriteLine($"Lokation: {b.Location}");
                                Console.WriteLine($"Menu: {b.menuPackage?.Name}");
                                Console.WriteLine($"Kommentar: {b.Comment}");
                                Console.WriteLine($"Status: {b.BookingStatus}");
                            }
                        }

                        break;


                   

                    default:

                        Console.WriteLine("\nUgyldigt valg!");

                        break;
                }

                Console.WriteLine("\nTryk på en tast for at fortsætte...");
                Console.ReadKey();
            }
        }
    }
}