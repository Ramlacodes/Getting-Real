using System.Text;

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

            // Tilføj menupakker
            menuRepo.AddMenuPackage(new MenuPackage(1, "Casablanca Kebab Wrap", 135));
            menuRepo.AddMenuPackage(new MenuPackage(2, "Fez Falafel Wrap", 135));
            menuRepo.AddMenuPackage(new MenuPackage(3, "Marrakech Chicken Wrap", 135));



            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("********************************");
                Console.WriteLine(" Marrakech Street Food System ");
                Console.WriteLine("********************************");

                Console.WriteLine("1. Opret kunde");
                Console.WriteLine("2. Opret booking");
                Console.WriteLine("3. Vis menupakker");
                Console.WriteLine("4. Afslut");

                Console.Write("\nVælg et nummer: ");

                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":

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


                        Customer customer1 = new Customer(navn, email, tlf);

                        Console.WriteLine("\nKunde oprettet!");
                        Console.WriteLine($"Navn: {navn}");
                        Console.WriteLine($"Email: {email}");
                        Console.WriteLine($"Telefon: {tlf}");

                        break;

                    case "2":

                        Console.WriteLine("\n--- BOOKING KOMMENTAR ---");

                        Console.WriteLine("Hvilket event er det?");
                        string eventType = Console.ReadLine();

                        Console.WriteLine("Tilføj kommentar eller allergier:");
                        string kommentar = Console.ReadLine();

                        Console.WriteLine("\nBookingoplysninger gemt!");

                        Console.WriteLine($"Event type: {eventType}");
                        Console.WriteLine($"Kommentar: {kommentar}");

                        break;

                    case "3":

                        Console.WriteLine("\n--- MENUPAKKER ---");

                        Console.WriteLine("\nMP001");
                        Console.WriteLine("Casablanca Kebab Wrap");
                        Console.WriteLine("135 kr");
                        Console.WriteLine("Crispy Wrap med Kebab, Salat og Husets Dressing");

                        Console.WriteLine("\nMP002");
                        Console.WriteLine("Fez Falafel Wrap");
                        Console.WriteLine("135 kr");
                        Console.WriteLine("Crispy Wrap med Falafel, Salat og Husets Dressing");

                        Console.WriteLine("\nMP003");
                        Console.WriteLine("Marrakech Chicken Wrap");
                        Console.WriteLine("135 kr");
                        Console.WriteLine("Crispy Wrap med Kylling, Salat og Husets Dressing");

                        break;

                    case "4":

                        Console.WriteLine("\nProgrammet afsluttes...");
                        isRunning = false;

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