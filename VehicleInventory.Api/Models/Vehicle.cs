namespace VehicleInventory.Api.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleBrand Brand { get; set; }
        public int Year { get; set; }
        public string Model { get; set; } = string.Empty;
        public bool IsAllWheelDrive { get; set; }
    }
}