using Fleet.Api.Models.Entities;
using SharedKernel.Models;

namespace Fleet.Api.Models.Repositories
{
    public class CompaniesRepository: BaseRepository<Company>
	{
		public CompaniesRepository(ApplicationContext context) : base(context) { }
	}
}
