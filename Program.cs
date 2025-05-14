using Bilbasen.Enums;
using Bilbasen.Models;

namespace Bilbasen
{
    public class Program
    {
        private List<Car> cars = new List<Car>();

        static void Main(string[] args)
        {
            Program program = new Program();

            program.Run();
        }

        private void Run()
        {
            cars.AddRange(Data.GetCars().OrderBy(car => car.ToString()).ToList());

            ConsoleKey? selectedKey = null;

            while (true)
            {
                Console.Clear();

                switch (selectedKey)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.D2:
                    case ConsoleKey.D3:
                    case ConsoleKey.D4:
                    case ConsoleKey.D5:
                        ShowCars(selectedKey.Value);

                        Console.WriteLine("\nBACKSPACE - Tilbage");

                        ConsoleKey consoleKey = Console.ReadKey(true).Key;

                        if (consoleKey == ConsoleKey.Backspace)
                        {
                            selectedKey = null;
                        }

                        break;
                    default:
                        Console.WriteLine(@"1 - Udskriv alle biler som deler mærke med den første bil i jeres datasæt.
2 - Udskriv alle biler som har over 200HK.
3 - Udskriv alle røde biler.
4 - Udskriv antallet af biler som har samme mærke som den første bil
5 - Udskriv alle biler som er mellem årgang 1980 og 1999");

                        selectedKey = Console.ReadKey(true).Key;

                        break;
                }
            }
        }

        private void ShowCars(ConsoleKey selectedKey)
        {
            Car? firstCar = cars.FirstOrDefault();

            switch (selectedKey)
            {
                case ConsoleKey.D1:
                    DisplayCarsByFirstCarManufacturer(firstCar);

                    break;
                case ConsoleKey.D2:
                    DisplayCarsWithHorsePowerOver200();

                    break;
                case ConsoleKey.D3:
                    DisplayRedCars();

                    break;
                case ConsoleKey.D4:
                    DisplayCarCountByFirstCarManufacturer(firstCar);

                    break;
                case ConsoleKey.D5:
                    DisplayCarsFrom1980To1999();

                    break;
            }
        }

        private void DisplayCarsByFirstCarManufacturer(Car? firstCar)
        {
            Console.WriteLine("Alle biler som deler mærke med den første bil i jeres datasæt:");

            foreach (Car car in cars.Where(car => car.Manufacturer == firstCar?.Manufacturer))
            {
                Console.WriteLine($"- {car.ToString()}");
            }
        }
        private void DisplayCarsWithHorsePowerOver200()
        {
            Console.WriteLine("Alle biler som har over 200HK:");

            foreach (Car car in cars.Where(car => car.HorsePower > 200))
            {
                Console.WriteLine($"- {car.ToString()}");
            }
        }

        private void DisplayRedCars()
        {
            Console.WriteLine("Alle røde biler:");

            foreach (Car car in cars.Where(car => car.Color == Colors.Red))
            {
                Console.WriteLine($"- {car.ToString()}");
            }
        }

        private void DisplayCarCountByFirstCarManufacturer(Car? firstCar)
        {
            Console.WriteLine("Antallet af biler som har samme mærke som den første bil:");

            int count = cars.Count(car => car.Manufacturer == firstCar?.Manufacturer);

            Console.WriteLine($"- {count}");
        }

        private void DisplayCarsFrom1980To1999()
        {
            Console.WriteLine("Alle biler som er mellem årgang 1980 og 1999:");

            foreach (Car car in cars.Where(car => car.Year >= 1980 && car.Year <= 1999))
            {
                Console.WriteLine($"- {car.ToString()}");
            }
        }
    }
}
