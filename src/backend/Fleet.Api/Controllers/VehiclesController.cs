using Fleet.Api.Models.Entities;
using Fleet.Api.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fleet.Api.Controllers
{
    [Authorize]
    [Route("vehicles")]
    public class VehiclesController : BaseController<Vehicle>
    {
		public VehiclesController(VehiclesRepository repository): base(repository) { }
	}
}