using Microsoft.EntityFrameworkCore;

namespace Fleet.Api.Models
{
    public class ApplicationContext: DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
	}
}

