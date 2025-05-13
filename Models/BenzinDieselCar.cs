using Bilbasen.Enums;

namespace Bilbasen.Models
{
    public class BenzinDieselCar : Car
    {
        private double _fuelCapacity;
        public double FuelCapacity { get => _fuelCapacity; set => _fuelCapacity = value; }

        private double _currentFuel;
        public double CurrentFuel { get => _currentFuel; set => _currentFuel = value; }

        private FuelType _fuelType;
        public FuelType FuelType { get => _fuelType; set => _fuelType = value; }

        public BenzinDieselCar(string model, string manufacturer, decimal price, int year, int horsePower, Colors color, string licensePlate, double mileage, double fuelCapacity, double currentFuel, FuelType fuelType)
            : base(model, manufacturer, price, year, horsePower, color, licensePlate, 4, mileage)
        {
            _fuelCapacity = fuelCapacity;
            _currentFuel = currentFuel;
            _fuelType = fuelType;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Manufacturer} {Model} ({FuelType}) motor startet med et brøl.");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Manufacturer} {Model} ({FuelType}) motor stoppet.");
        }

        public void Refuel(double amount)
        {
            CurrentFuel += amount;

            if (CurrentFuel > FuelCapacity)
            {
                CurrentFuel = FuelCapacity;
            }

            Console.WriteLine($"{Manufacturer} {Model} tanket op til {CurrentFuel}/{FuelCapacity} liter ({FuelType}).");
        }
    }
}
