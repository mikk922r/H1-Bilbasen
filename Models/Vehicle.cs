using Bilbasen.Enums;

namespace Bilbasen.Models
{
    public class Vehicle
    {
        private string _model;
        public string Model { get => _model; set => _model = value; }

        private string _manufacturer;
        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }

        private int _year;
        public int Year { get => _year; set => _year = value; }

        public int _horsePower;
        public int HorsePower { get => _horsePower; set => _horsePower = value; }

        private Colors _color;
        public Colors Color { get => _color; set => _color = value; }

        private string _licensePlate;
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }

        private int _numberOfWheels;
        public int NumberOfWheels { get => _numberOfWheels; set => _numberOfWheels = value; }

        private double _mileage;
        public double Mileage { get => _mileage; set => _mileage = value; }

        public Vehicle(string model, string manufacturer, int year, int horsePower, Colors color, string licensePlate, int numberOfWheels, double mileage)
        {
            _model = model;
            _manufacturer = manufacturer;
            _year = year;
            _horsePower = horsePower;
            _color = color;
            _licensePlate = licensePlate;
            _numberOfWheels = numberOfWheels;
            _mileage = mileage;
        }
    }
}