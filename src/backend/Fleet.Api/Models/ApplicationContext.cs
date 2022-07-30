using Fleet.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fleet.Api.Models
{
    public class ApplicationContext: DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}

