using Bilbasen.Enums;

namespace Bilbasen.Models
{
    public abstract class Car : Vehicle, ICar
    {
        private decimal _price;
        public decimal Price { get => _price; set => _price = value; }

        public Car(string model, string manufacturer, decimal price, int year, int horsePower, Colors color, string licensePlate, int numberOfWheels, double mileage)
            : base(model, manufacturer, year, horsePower, color, licensePlate, numberOfWheels, mileage)
        {
            _price = price;
        }

        public abstract void StartEngine();

        public abstract void StopEngine();

        public override string ToString()
        {
            return $"{Manufacturer} {Model} ({Year}) - {HorsePower} HP - {Color} - {LicensePlate} - {Price:C}";
        }
    }
}
