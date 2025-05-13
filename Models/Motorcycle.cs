using Bilbasen.Enums;

namespace Bilbasen.Models
{
    public class Motorcycle : Vehicle
    {
        private bool _hasSidecar;
        public bool HasSidecar { get => _hasSidecar; set => _hasSidecar = value; }

        public Motorcycle(string model, string manufacturer, int year, int horsePower, Colors color, string licensePlate, double mileage, bool hasSidecar)
            : base(model, manufacturer, year, horsePower, color, licensePlate, hasSidecar ? 3 : 2, mileage)
        {
            _hasSidecar = hasSidecar;
        }
    }
}
