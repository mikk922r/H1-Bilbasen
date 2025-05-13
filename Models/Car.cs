using Bilbasen.Enums;

namespace Bilbasen.Models
{
    public class Car
    {

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public Colors Color { get; set; }
        public FuelType FuelType { get; set; }
        public int Year { get; set; }
        public int HorsePower { get; set; }
        public bool IsManual { get; set; }

        public Car(string model, string manufacturer, Colors color, FuelType fuelType, int year, bool isManual)
        {
            Model = model;
            Manufacturer = manufacturer;
            Color = color;
            FuelType = fuelType;
            Year = year;
            IsManual = isManual;
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} ({Year}) - {Color} - {FuelType} - {(IsManual ? "Manual" : "Automatic")}";
        }
    }
}
