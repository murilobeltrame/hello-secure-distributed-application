using Fleet.Api.Models.Entities;
using Fleet.Api.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedKernel.Web.Controllers;

namespace Fleet.Api.Controllers
{
    [Authorize]
    [Route("groups")]
    public class GroupsController: BaseController<Group>
    {
		public GroupsController(GroupsRepository repository) : base(repository) { }
	}
}

