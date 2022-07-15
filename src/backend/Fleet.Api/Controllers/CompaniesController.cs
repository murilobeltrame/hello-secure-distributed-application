using Fleet.Api.Models.Entities;
using Fleet.Api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fleet.Api.Controllers
{
    [Route("companies")]
    public class CompaniesController : BaseController<Company>
    {
        public CompaniesController(CompaniesRepository repository) : base(repository) { }
    }
}

