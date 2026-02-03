using VehicleInventory.Api.Models;


namespace VehicleInventory.Api.BusinessLogic.Interfaces
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetVehicles();
        Vehicle? GetVehicle(int id);
        void CreateVehicle(Vehicle vehicle);
        bool UpdateVehicle(int id, Vehicle vehicle);
        bool DeleteVehicle(int id);
    }
}