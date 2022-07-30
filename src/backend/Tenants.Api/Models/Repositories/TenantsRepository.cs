using SharedKernel.Models;
using Tenants.Api.Models.Entities;

namespace Tenants.Api.Models.Repositories
{
    public class TenantsRepository : BaseRepository<Tenant>
    {
        public TenantsRepository(ApplicationContext context) : base(context) { }
    }
}
