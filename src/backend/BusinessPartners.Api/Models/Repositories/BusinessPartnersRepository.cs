using BusinessPartners.Api.Models.Entities;
using SharedKernel.Models;

namespace BusinessPartners.Api.Models.Repositories
{
    public class BusinessPartnersRepository : BaseRepository<BusinessPartner>
    {
        public BusinessPartnersRepository(ApplicationContext context) : base(context) { }
    }
}

