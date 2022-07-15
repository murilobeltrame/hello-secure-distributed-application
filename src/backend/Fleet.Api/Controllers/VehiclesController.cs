using Fleet.Api.Models.Entities;
using Fleet.Api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Fleet.Api.Controllers
{
    [Route("vehicles")]
    public class VehiclesController : BaseController<Vehicle>
    {
		public VehiclesController(VehiclesRepository repository): base(repository) { }
	}
}