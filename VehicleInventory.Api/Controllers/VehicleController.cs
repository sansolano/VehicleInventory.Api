using Microsoft.AspNetCore.Mvc;
using VehicleInventory.Api.Models;
using VehicleInventory.Api.BusinessLogic.Interfaces;


namespace VehicleInventory.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _service;


        public VehiclesController(IVehicleService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetVehicles());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var vehicle = _service.GetVehicle(id);
            if (vehicle == null) return NotFound();


            return Ok(vehicle);
        }


        [HttpPost]
        public IActionResult Create([FromBody] Vehicle vehicle)
        {
            _service.CreateVehicle(vehicle);
            return CreatedAtAction(nameof(GetById), new { id = vehicle.Id }, vehicle);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Vehicle vehicle)
        {
            var updated = _service.UpdateVehicle(id, vehicle);
            if (!updated) return NotFound();


            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _service.DeleteVehicle(id);
            if (!deleted) return NotFound();


            return NoContent();
        }
    }
}