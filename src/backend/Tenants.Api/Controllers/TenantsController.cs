using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedKernel.Web.Controllers;
using Tenants.Api.Models.Entities;
using Tenants.Api.Models.Repositories;

namespace Tenants.Api.Controllers
{
    //[Authorize]
    [Route("tenants")]
    public class TenantsController : BaseController<Tenant>
    {
        public TenantsController(TenantsRepository repository) : base(repository) { }
    }
}
