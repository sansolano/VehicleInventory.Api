using VehicleInventory.Api.Models;
using VehicleInventory.Api.DataAccess.Interfaces;
using VehicleInventory.Api.BusinessLogic.Interfaces;


namespace VehicleInventory.Api.BusinessLogic
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _repository;


        public VehicleService(IVehicleRepository repository)
        {
            _repository = repository;
        }


        public IEnumerable<Vehicle> GetVehicles() => _repository.GetAll();


        public Vehicle? GetVehicle(int id) => _repository.GetById(id);


        public void CreateVehicle(Vehicle vehicle)
        {
            _repository.Add(vehicle);
        }


        public bool UpdateVehicle(int id, Vehicle vehicle)
        {
            var existing = _repository.GetById(id);
            if (existing == null) return false;


            vehicle.Id = id;
            _repository.Update(vehicle);
            return true;
        }


        public bool DeleteVehicle(int id)
        {
            var existing = _repository.GetById(id);
            if (existing == null) return false;


            _repository.Delete(id);
            return true;
        }
    }
}