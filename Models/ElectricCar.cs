using Bilbasen.Enums;

namespace Bilbasen.Models
{
    public class ElectricCar : Car
    {
        private double _batteryCapacity;
        public double BatteryCapacity { get => _batteryCapacity; set => _batteryCapacity = value; }

        private double _currentCharge;
        public double CurrentCharge { get => _currentCharge; set => _currentCharge = value; }

        public ElectricCar(string model, string manufacturer, decimal price, int year, int horsePower, Colors color, string licensePlate, double mileage, double batteryCapacity, double currentCharge)
            : base(model, manufacturer, price, year, horsePower, color, licensePlate, 4, mileage)
        {
            _batteryCapacity = batteryCapacity;
            _currentCharge = currentCharge;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Manufacturer} {Model} elektrisk motor startet lydløst.");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Manufacturer} {Model} elektrisk motor stoppet.");
        }

        public void ChargeBattery(double amount)
        {
            CurrentCharge += amount;

            if (CurrentCharge > BatteryCapacity)
            {
                CurrentCharge = BatteryCapacity;
            }

            Console.WriteLine($"{Manufacturer} {Model} ladet op til {CurrentCharge}/{BatteryCapacity} kWh.");
        }
    }
}
