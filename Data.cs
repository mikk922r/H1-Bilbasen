using Bilbasen.Models;
using Newtonsoft.Json;

namespace Bilbasen
{
    public class Data
    {
        public static List<Car> GetCars()
        {
            List<BenzinDieselCar> benzinDieselCars = GetCars<BenzinDieselCar>("benzin_diesel_cars.json");
            List<ElectricCar> electricCars = GetCars<ElectricCar>("electric_cars.json");

            return benzinDieselCars.Cast<Car>().Concat(electricCars).ToList();
        }

        private static List<T> GetCars<T>(string fileName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../", $"JSON/{fileName}");

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            string text = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<List<T>>(text) ?? new List<T>();
        }
    }
}
