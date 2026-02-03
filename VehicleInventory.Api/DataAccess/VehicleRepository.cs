using VehicleInventory.Api.Models;
using VehicleInventory.Api.DataAccess.Interfaces;


namespace VehicleInventory.Api.DataAccess
{
    public class VehicleRepository : IVehicleRepository
    {
        private static readonly List<Vehicle> Vehicles = new();
        private static int _currentId = 1;


        public IEnumerable<Vehicle> GetAll() => Vehicles;


        public Vehicle? GetById(int id) => Vehicles.FirstOrDefault(v => v.Id == id);


        public void Add(Vehicle vehicle)
        {
            vehicle.Id = _currentId++;
            Vehicles.Add(vehicle);
        }


        public void Update(Vehicle vehicle)
        {
            var existing = GetById(vehicle.Id);
            if (existing == null) return;


            existing.Brand = vehicle.Brand;
            existing.Year = vehicle.Year;
            existing.Model = vehicle.Model;
            existing.IsAllWheelDrive = vehicle.IsAllWheelDrive;
        }


        public void Delete(int id)
        {
            var vehicle = GetById(id);
            if (vehicle != null)
                Vehicles.Remove(vehicle);
        }
    }
}