Dokumentation til OOP
Til dette system har vi anvendt objektorienteret programmering til at strukturere det. OOP gør det muligt at opdele vores system i klasser, der repræsenterer virkelig objekter som kunde, menupakker og booking. 
Beskrivelse af klasser: 
Booking: 
Klassen Booking repræsenterer en reservation i systemet. Den indeholder oplysninger som event type, dato, antal kuverter, lokation og kommentar. 
Derudover er booking forbundet med både en Customer og en MenuPackage, hvilket viser relationen mellem objekterne. 
Customer:
Klassen Customer repræsenterer en kunde, denne indeholder navn, email og telefonnummer. Kunden bliver knyttet til en booking. 
MenuPackage: 
Klassen MenuPackage repræsenterer en menupakke med navn, pris pr. kuvert og ingredienser. En booking referer til en valgt menupakke. 
Repositories: 
 BookingRepository og MenuPackageRepository bruges til at gemme og hente data. Vi bruger dette til at adskille datahåndtering fra programlogik, hvilket gør systemet mere overskueligt. 
OOP principper: 
Encapsulation (Indkapsling)
Klasserne bruger properties til at beskytte vores data. Dette bliver ikke ændret direkte, men gennem objektets struktur. 
Komposition:
Booking indeholder både en Customer og en MenuPackage. Dette viser en "has-a" relation, hvor en booking har en kunde og en menu.
Interface: 
IPriceCalculator er et interface, som gør det muligt at ændre prisberegning uden at ændre resten af systemet.
Sammenhæng mellem klasser (kobling)
Systemets klasser arbejder sammen ved at Main opretter objekter og bruger repositories til at gemme og hente data. Booking-objekter forbinder Customer og MenuPackage, hvilket skaber en sammenhængende datastruktur.
Designvalg:
Object initializer er anvendt til at oprette objekter, da data indsamles fra brugerinput trin for trin. Dette gør koden mere fleksibel og nemmere at læse.
Konklusion:
OOP har gjort systemet mere struktureret, overskueligt og nemt at udvide. Ved at opdele systemet i klasser og bruge principper som komposition og encapsulation, bliver koden mere vedligeholdelsesvenlig.
Systemet kan nemt udvides med nye funktioner, fx flere menupakker eller nye bookingtyper, uden at ændre eksisterende kode.
