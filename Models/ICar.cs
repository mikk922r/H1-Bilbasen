namespace Bilbasen.Models
{
    public interface ICar
    {
        string Model { get; set; }
        string Manufacturer { get; set; }
        decimal Price { get; set; }
    }
}