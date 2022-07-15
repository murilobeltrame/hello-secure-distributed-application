using Fleet.Api.Models.Entities;

namespace Fleet.Api.Models.Repositories
{
    public class GroupsRepository: BaseRepository<Group>
	{
		public GroupsRepository(ApplicationContext context) : base(context) { }
	}
}
