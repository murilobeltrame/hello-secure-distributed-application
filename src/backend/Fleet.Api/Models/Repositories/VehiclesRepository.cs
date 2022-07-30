using Fleet.Api.Models.Entities;
using SharedKernel.Models;

namespace Fleet.Api.Models.Repositories
{
    public class VehiclesRepository: BaseRepository<Vehicle>
	{
		public VehiclesRepository(ApplicationContext context) : base(context) { }
	}
}
