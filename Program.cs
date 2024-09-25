class Program
{
    struct Passenger
    {
        public string lastName;
        public int flightNumber;
        public int baggageWeight;

        public string GetInfo()
        {
            return $"{lastName} Рейс: {flightNumber} Багаж: {baggageWeight} кг";
        }
    }

    static void Main(string[] args)
    {
        List<Passenger> passengers = new List<Passenger>();
        Passenger pass;
        int n = 4;  

        Console.WriteLine("Введiть данi про пасажирiв (Прiзвище, Номер рейсу, Вага багажу):");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Прiзвище: ");
            pass.lastName = Console.ReadLine();
            Console.Write("Номер рейсу: ");
            pass.flightNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вага багажу: ");
            pass.baggageWeight = Convert.ToInt32(Console.ReadLine());
            passengers.Add(pass);
        }

        Console.WriteLine("\nСписок пасажирiв:");
        foreach (var passenger in passengers)
        {
            Console.WriteLine(passenger.GetInfo());
        }

        Console.Write("\nВведiть номер рейсу для пошуку: ");
        int searchFlightNumber = Convert.ToInt32(Console.ReadLine());

        int passengerCount = 0;
        int totalBaggageWeight = 0;

        foreach (var passenger in passengers)
        {
            if (passenger.flightNumber == searchFlightNumber)
            {
                passengerCount++;
                totalBaggageWeight += passenger.baggageWeight;
            }
        }

        if (passengerCount > 0)
        {
            Console.WriteLine($"\nКiлькiсть пасажирiв на рейсi {searchFlightNumber}: {passengerCount}");
            Console.WriteLine($"Загальна вага багажу: {totalBaggageWeight} кг");
        }
        else
        {
            Console.WriteLine($"\nНемає пасажирiв на рейсi {searchFlightNumber}");
        }

        Console.ReadKey();
    }
}
