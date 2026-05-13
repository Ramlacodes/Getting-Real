namespace Getting_Real
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            bool isRunning = true;
            while (isRunning) {
            
            Console.WriteLine("\t************************************");
            Console.WriteLine("\tMarrakech Street-Foods Bookingsystem");
            Console.WriteLine("\t************************************");

            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();

            Console.WriteLine("Indtast email");
            string email = Console.ReadLine();

            Console.WriteLine("Indtast telefonnummer");
            int tlf = Convert.ToInt32(Console.ReadLine());

            
            Kunde kunde1 = new Kunde(navn, email, tlf);
            
            Console.WriteLine($"Navn: {navn}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Télefon: {tlf}");

            }

            Console.ReadKey();
        }
    }
}
