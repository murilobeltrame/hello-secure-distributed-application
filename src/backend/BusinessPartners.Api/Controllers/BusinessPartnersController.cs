using System;
using BusinessPartners.Api.Models.Entities;
using BusinessPartners.Api.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedKernel.Web.Controllers;

namespace BusinessPartners.Api.Controllers
{
    [Authorize]
    [Route("business-partners")]
    public class BusinessPartnersController : BaseController<BusinessPartner>
    {
        public BusinessPartnersController(BusinessPartnersRepository repository) : base(repository) { }
    }
}

