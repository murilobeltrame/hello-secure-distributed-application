using Fleet.Api.Models.Entities;

namespace Fleet.Api.Models.Repositories
{
    public class CompaniesRepository: BaseRepository<Company>
	{
		public CompaniesRepository(ApplicationContext context) : base(context) { }
	}
}
