using Fleet.Api.Models.Entities;
using SharedKernel.Models;

namespace Fleet.Api.Models.Repositories
{
    public class GroupsRepository: BaseRepository<Group>
	{
		public GroupsRepository(ApplicationContext context) : base(context) { }
	}
}
